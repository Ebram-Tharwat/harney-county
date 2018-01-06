using HarneyCounty.Application.Core.Enums;
using HarneyCounty.Application.Core.Interfaces;
using HarneyCounty.Application.Core.ViewModel.Audit;
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

        public ExcelExportingService(IFiscalYearBeginningBalanceService fiscalYearBeginningBalanceService, IAuditService auditService)
        {
            _fiscalYearBeginningBalanceService = fiscalYearBeginningBalanceService;
            _auditService = auditService;
        }

        public MemoryStream GetBeginingBalancesTemplate(int fiscalYearId)
        {
            string excelTemplate = GetExcelTemplate(ReportType.BeginingBalances);
            var templateFile = new FileInfo(excelTemplate);
            ExcelPackage package = new ExcelPackage(templateFile, true);

            var fiscalYear = _auditService.GetAuditFiscalYear(fiscalYearId);
            GenerateBeginingBalancesReportExcel(package, _fiscalYearBeginningBalanceService.GetByFiscalYearId(fiscalYearId), fiscalYear.FiscalYear.ToString());

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

        #endregion Audit

        #region Private Methods

        private string GetExcelTemplate(ReportType type)
        {
            string templatePath = String.Empty;

            switch (type)
            {
                case ReportType.BeginingBalances:
                    templatePath = System.AppDomain.CurrentDomain.BaseDirectory + "Content\\ExcelTemplates\\BeginingBalancesTemplate.xlsx";
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