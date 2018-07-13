using HarneyCounty.Application.Core.Enums;
using HarneyCounty.Application.Core.Interfaces;
using HarneyCounty.Application.Core.ViewModel.Audit;
using HarneyCounty.Application.Core.ViewModel.Payroll;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HarneyCounty.Application.Core.Services
{
    public class ExcelExportingService : IExportingService
    {
        private readonly IFiscalYearBeginningBalanceService _fiscalYearBeginningBalanceService;
        private readonly IAuditService _auditService;
        private readonly IEmployeeMasterService _employeeMasterService;

        public ExcelExportingService(IFiscalYearBeginningBalanceService fiscalYearBeginningBalanceService, IAuditService auditService
            , IEmployeeMasterService employeeMasterService)
        {
            _fiscalYearBeginningBalanceService = fiscalYearBeginningBalanceService;
            _auditService = auditService;
            _employeeMasterService = employeeMasterService;
        }

        public MemoryStream GetBeginingBalancesReport(int fiscalYearId)
        {
            string excelTemplate = GetExcelTemplate(ReportType.BeginingBalances);
            var templateFile = new FileInfo(excelTemplate);
            ExcelPackage package = new ExcelPackage(templateFile, true);

            var fiscalYear = _auditService.GetAuditFiscalYear(fiscalYearId);
            GenerateBeginingBalancesReportExcel(package, _fiscalYearBeginningBalanceService.GetByFiscalYearId(fiscalYearId), fiscalYear.FiscalYear.ToString());

            var stream = new MemoryStream(package.GetAsByteArray());
            return stream;
        }

        public MemoryStream GetDailyDetailReport(DailyDetailReportFiltersViewModel filter)
        {
            string excelTemplate = GetExcelTemplate(ReportType.DailyDetail);
            var templateFile = new FileInfo(excelTemplate);
            ExcelPackage package = new ExcelPackage(templateFile, true);

            GenerateDailyDetailReportExcel(package, _auditService.GetDailyDetailReport(filter));

            var stream = new MemoryStream(package.GetAsByteArray());
            return stream;
        }

        public MemoryStream GetEmployeeDeductionsReport(PayHistoryFilterViewModel filter, int id)
        {
            string excelTemplate = GetExcelTemplate(ReportType.EmployeeDeductions);
            var templateFile = new FileInfo(excelTemplate);
            ExcelPackage package = new ExcelPackage(templateFile, true);

            GenerateEmployeeDedtionsReportExcel(package, _employeeMasterService.GetById(id, filter));

            var stream = new MemoryStream(package.GetAsByteArray());
            return stream;
        }

        #region Audit

        private void GenerateBeginingBalancesReportExcel(ExcelPackage excelPackage, List<FiscalYearBeginningBalanceViewModel> reportData, string fiscalYearName)
        {
            var dataSheet = excelPackage.Workbook.Worksheets[1];
            dataSheet.Name = fiscalYearName;
            var sheetStartingIndex = 2;
            var rowIndex = sheetStartingIndex; // starting index of each sheet.
            foreach (var item in reportData)
            {
                dataSheet.Cells["A" + rowIndex].Value = item.Year;
                dataSheet.Cells["B" + rowIndex].Value = item.BeginningBalance;
                dataSheet.Cells["C" + rowIndex].Value = item.YtdCollections;
                dataSheet.Cells["D" + rowIndex].Value = item.YtdLosses;
                dataSheet.Cells["E" + rowIndex].Value = item.YtdGains;
                dataSheet.Cells["F" + rowIndex].Value = item.YtdBalance;
                rowIndex++;
            }

            if (reportData.Any())
            {
                // add totals column
                dataSheet.Cells[$"A{rowIndex}:F{rowIndex}"].Style.Font.Bold = true;
                dataSheet.Cells["A" + rowIndex].Value = "Total";
                dataSheet.Cells["B" + rowIndex].Formula = $"=SUM(${dataSheet.Cells["B" + sheetStartingIndex].Address}"
                            + $":${dataSheet.Cells["B" + ((reportData.Count - 1) + sheetStartingIndex)].Address})";
                dataSheet.Cells["C" + rowIndex].Formula = $"=SUM(${dataSheet.Cells["C" + sheetStartingIndex].Address}"
                            + $":${dataSheet.Cells["C" + ((reportData.Count - 1) + sheetStartingIndex)].Address})";
                dataSheet.Cells["D" + rowIndex].Formula = $"=SUM(${dataSheet.Cells["D" + sheetStartingIndex].Address}"
                            + $":${dataSheet.Cells["D" + ((reportData.Count - 1) + sheetStartingIndex)].Address})";
                dataSheet.Cells["E" + rowIndex].Formula = $"=SUM(${dataSheet.Cells["E" + sheetStartingIndex].Address}"
                            + $":${dataSheet.Cells["E" + ((reportData.Count - 1) + sheetStartingIndex)].Address})";
                dataSheet.Cells["F" + rowIndex].Formula = $"=SUM(${dataSheet.Cells["F" + sheetStartingIndex].Address}"
                            + $":${dataSheet.Cells["F" + ((reportData.Count - 1) + sheetStartingIndex)].Address})";
            }

            dataSheet.Cells.AutoFitColumns();
        }

        private void GenerateDailyDetailReportExcel(ExcelPackage excelPackage, List<DailyDetailReportGroupedByTaxYearViewModel> reportData)
        {
            //var dataSheet = excelPackage.Workbook.Worksheets[1];
            var sheetStartingIndex = 2;
            var rowIndex = sheetStartingIndex; // starting index of each sheet.
            foreach (var group in reportData)
            {
                var taxyearSheet = excelPackage.Workbook.Worksheets.Add(group.TaxYear.ToString(), excelPackage.Workbook.Worksheets[1]);
                rowIndex = 2;
                decimal previousBalance = 0;
                foreach (var item in group.Items)
                {
                    taxyearSheet.Cells["A" + rowIndex].Value = item.TaxYear;
                    taxyearSheet.Cells["B" + rowIndex].Value = item.EntryDate;
                    taxyearSheet.Cells["C" + rowIndex].Value = item.CurrRcpts;
                    taxyearSheet.Cells["D" + rowIndex].Value = item.StatePercentage;
                    taxyearSheet.Cells["E" + rowIndex].Value = item.Penalities;
                    taxyearSheet.Cells["F" + rowIndex].Value = item.RefundsNsf;
                    taxyearSheet.Cells["G" + rowIndex].Value = item.NetRcpts;
                    taxyearSheet.Cells["H" + rowIndex].Value = item.C12PercentageInterest;
                    taxyearSheet.Cells["I" + rowIndex].Value = item.C16PercentageInterest;
                    taxyearSheet.Cells["J" + rowIndex].Value = item.Discount;
                    taxyearSheet.Cells["K" + rowIndex].Value = item.NetTaxCr;
                    if (group.Items[0] == item)
                    {
                        item.BalanceForward = item.BeginningBalance + (item.GainsToRoll ?? 0) - (item.LossesToRoll ?? 0) - (item.NetRollChg);
                        previousBalance = item.BalanceForward;
                        taxyearSheet.Cells["L" + rowIndex].Value = item.BalanceForward;
                    }
                    else
                    {
                        item.BalanceForward = previousBalance + (item.GainsToRoll ?? 0) -  (item.LossesToRoll ?? 0) - (item.NetRollChg);
                        previousBalance = item.BalanceForward;
                        taxyearSheet.Cells["L" + rowIndex].Value = item.BalanceForward;
                    }
                    rowIndex++;
                }

                if (group.Items.Any())
                {
                    // add totals column
                    taxyearSheet.Cells[$"A{rowIndex}:J{rowIndex}"].Style.Font.Bold = true;
                    taxyearSheet.Cells["A" + rowIndex].Value = "Total";
                    taxyearSheet.Cells["C" + rowIndex].Formula = $"=SUM(${taxyearSheet.Cells["C" + sheetStartingIndex].Address}"
                                + $":${taxyearSheet.Cells["C" + ((group.Items.Count - 1) + sheetStartingIndex)].Address})";
                    taxyearSheet.Cells["D" + rowIndex].Formula = $"=SUM(${taxyearSheet.Cells["D" + sheetStartingIndex].Address}"
                                + $":${taxyearSheet.Cells["D" + ((group.Items.Count - 1) + sheetStartingIndex)].Address})";
                    taxyearSheet.Cells["E" + rowIndex].Formula = $"=SUM(${taxyearSheet.Cells["E" + sheetStartingIndex].Address}"
                                + $":${taxyearSheet.Cells["E" + ((group.Items.Count - 1) + sheetStartingIndex)].Address})";
                    taxyearSheet.Cells["F" + rowIndex].Formula = $"=SUM(${taxyearSheet.Cells["F" + sheetStartingIndex].Address}"
                                + $":${taxyearSheet.Cells["F" + ((group.Items.Count - 1) + sheetStartingIndex)].Address})";
                    taxyearSheet.Cells["G" + rowIndex].Formula = $"=SUM(${taxyearSheet.Cells["G" + sheetStartingIndex].Address}"
                                + $":${taxyearSheet.Cells["G" + ((group.Items.Count - 1) + sheetStartingIndex)].Address})";
                    taxyearSheet.Cells["H" + rowIndex].Formula = $"=SUM(${taxyearSheet.Cells["H" + sheetStartingIndex].Address}"
                                + $":${taxyearSheet.Cells["H" + ((group.Items.Count - 1) + sheetStartingIndex)].Address})";
                    taxyearSheet.Cells["I" + rowIndex].Formula = $"=SUM(${taxyearSheet.Cells["I" + sheetStartingIndex].Address}"
                                + $":${taxyearSheet.Cells["I" + ((group.Items.Count - 1) + sheetStartingIndex)].Address})";
                    taxyearSheet.Cells["J" + rowIndex].Formula = $"=SUM(${taxyearSheet.Cells["J" + sheetStartingIndex].Address}"
                                + $":${taxyearSheet.Cells["J" + ((group.Items.Count - 1) + sheetStartingIndex)].Address})";
                    taxyearSheet.Cells["K" + rowIndex].Formula = $"=SUM(${taxyearSheet.Cells["K" + sheetStartingIndex].Address}"
                                + $":${taxyearSheet.Cells["K" + ((group.Items.Count - 1) + sheetStartingIndex)].Address})";
                    taxyearSheet.Cells["L" + rowIndex].Value = group.Items.FirstOrDefault().BalanceForward;
                }

                taxyearSheet.Cells.AutoFitColumns();
                taxyearSheet.View.TabSelected = false;
            }

            // add grand total sheet
            if (reportData.Any())
            {
                var totalSheet = excelPackage.Workbook.Worksheets.Add("Grand Total", excelPackage.Workbook.Worksheets[1]);
                rowIndex = 2;
                totalSheet.Cells[$"A{rowIndex}:J{rowIndex}"].Style.Font.Bold = true;
                totalSheet.Cells["A" + rowIndex].Value = "Total";
                totalSheet.Cells["C" + rowIndex].Value = reportData.Sum(group => group.Items.Sum(item => item.CurrRcpts));
                totalSheet.Cells["D" + rowIndex].Value = reportData.Sum(group => group.Items.Sum(item => item.StatePercentage));
                totalSheet.Cells["E" + rowIndex].Value = reportData.Sum(group => group.Items.Sum(item => item.Penalities));
                totalSheet.Cells["F" + rowIndex].Value = reportData.Sum(group => group.Items.Sum(item => item.RefundsNsf));
                totalSheet.Cells["G" + rowIndex].Value = reportData.Sum(group => group.Items.Sum(item => item.NetRcpts));
                totalSheet.Cells["H" + rowIndex].Value = reportData.Sum(group => group.Items.Sum(item => item.C12PercentageInterest));
                totalSheet.Cells["I" + rowIndex].Value = reportData.Sum(group => group.Items.Sum(item => item.C16PercentageInterest));
                totalSheet.Cells["J" + rowIndex].Value = reportData.Sum(group => group.Items.Sum(item => item.Discount));
                totalSheet.Cells["K" + rowIndex].Value = reportData.Sum(group => group.Items.Sum(item => item.NetTaxCr));
                totalSheet.Cells["L" + rowIndex].Value = reportData.Sum(group => group.Items.FirstOrDefault().BalanceForward);

                totalSheet.Cells.AutoFitColumns();
                totalSheet.View.TabSelected = false;
            }

            excelPackage.Workbook.Worksheets.Delete(1);
        }

        #endregion Audit

        #region Payroll

        private void GenerateEmployeeDedtionsReportExcel(ExcelPackage excelPackage, EmployeeMasterViewModel reportData)
        {
            var dataSheet = excelPackage.Workbook.Worksheets[1];
            dataSheet.Name = $"Emp # {reportData.EmployeeNumber}";
            var sheetStartingIndex = 2;
            var rowIndex = sheetStartingIndex; // starting index of each sheet.
            foreach (var item in reportData.Deductions)
            {
                dataSheet.Cells["A" + rowIndex].Value = item.DeductionCode;
                dataSheet.Cells["B" + rowIndex].Value = item.DeductionDesc;
                dataSheet.Cells["C" + rowIndex].Value = item.PayPeriodEndingDate;
                dataSheet.Cells["D" + rowIndex].Value = item.Check;
                dataSheet.Cells["E" + rowIndex].Value = item.DirectDepositStatus;
                dataSheet.Cells["F" + rowIndex].Value = item.EmployeeAmt;
                dataSheet.Cells["G" + rowIndex].Value = item.EmployerAmt;
                dataSheet.Cells["H" + rowIndex].Value = item.EmployeeAmtPickedUp;
                rowIndex++;
            }

            if (reportData.Deductions.Any())
            {
                // add totals column
                dataSheet.Cells[$"A{rowIndex}:H{rowIndex}"].Style.Font.Bold = true;
                dataSheet.Cells["F" + rowIndex].Formula = $"=SUM(${dataSheet.Cells["F" + sheetStartingIndex].Address}"
                            + $":${dataSheet.Cells["F" + ((reportData.Deductions.Count - 1) + sheetStartingIndex)].Address})";
                dataSheet.Cells["G" + rowIndex].Formula = $"=SUM(${dataSheet.Cells["G" + sheetStartingIndex].Address}"
                            + $":${dataSheet.Cells["G" + ((reportData.Deductions.Count - 1) + sheetStartingIndex)].Address})";
                dataSheet.Cells["H" + rowIndex].Formula = $"=SUM(${dataSheet.Cells["H" + sheetStartingIndex].Address}"
                            + $":${dataSheet.Cells["H" + ((reportData.Deductions.Count - 1) + sheetStartingIndex)].Address})";
            }

            dataSheet.Cells.AutoFitColumns();
        }

        #endregion Payroll

        #region Private Methods

        private string GetExcelTemplate(ReportType type)
        {
            string templatePath = String.Empty;

            switch (type)
            {
                case ReportType.BeginingBalances:
                    templatePath = System.AppDomain.CurrentDomain.BaseDirectory + "Content\\ExcelTemplates\\BeginingBalancesTemplate.xlsx";
                    break;

                case ReportType.DailyDetail:
                    templatePath = System.AppDomain.CurrentDomain.BaseDirectory + "Content\\ExcelTemplates\\DailyDetailTemplate.xlsx";
                    break;

                case ReportType.EmployeeDeductions:
                    templatePath = System.AppDomain.CurrentDomain.BaseDirectory + "Content\\ExcelTemplates\\EmployeeDeductionsTemplate.xlsx";
                    break;

                default:
                    templatePath = String.Empty;
                    break;
            }

            return templatePath;
        }

        #endregion Private Methods
    }
}