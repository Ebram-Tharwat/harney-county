using AutoMapper;
using HarneyCounty.Application.Core.Interfaces;
using HarneyCounty.Application.Core.ViewModel.Audit;
using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Infrastructure.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HarneyCounty.Application.Core.Services
{
    public class AuditService : IAuditService
    {
        private readonly IRepository<AuditFiscalYear> _auditFiscalYearRepository;
        private readonly IRepository<AuditTurnoverSequence> _auditTurnOverSequenceRepository;
        private readonly IRepository<DailyMaster> _dailyMasterRepository;
        private readonly IAuditDailyDetailRepository _auditDailyDetailRepository;
        private readonly IFiscalYearBeginningBalanceRepository _fiscalYearBeginningBalanceRepository;
        private readonly IUnitOfWork _unitOfWork;

        public AuditService(IRepository<AuditFiscalYear> repository, IRepository<AuditTurnoverSequence> auditTurnOverSequenceRepository
            , IRepository<DailyMaster> dailyMasterRepository, IAuditDailyDetailRepository auditDailyDetailRepository
            , IFiscalYearBeginningBalanceRepository fiscalYearBeginningBalanceRepository, IUnitOfWork unitOfWork)
        {
            _auditFiscalYearRepository = repository;
            _auditTurnOverSequenceRepository = auditTurnOverSequenceRepository;
            _dailyMasterRepository = dailyMasterRepository;
            _auditDailyDetailRepository = auditDailyDetailRepository;
            _fiscalYearBeginningBalanceRepository = fiscalYearBeginningBalanceRepository;
            _unitOfWork = unitOfWork;
        }

        public List<AuditFiscalYear> GetAllAuditFiscalYears()
        {
            var result = _auditFiscalYearRepository.GetAll().Where(f => f.IsActive.HasValue && f.IsActive.Value).ToList();
            return result;
        }

        public List<DailyMaster> GetAllDailyMasterByAuditTurnOverSequenceId(int id)
        {
            return _dailyMasterRepository
                   .Get((dailyMasterItem) => dailyMasterItem.AuditTurnoverSequenceId == id)
                   .Where(dailyMasterItem => dailyMasterItem.IsActive.HasValue && dailyMasterItem.IsActive.Value).ToList();
        }

        public DailyMaster GetDailyMasterById(int id)
        {
            return _dailyMasterRepository.GetById(id);
        }

        public List<AuditDailyDetail> GetAllDailyDetailByDailyMasterId(int id)
        {
            return _auditDailyDetailRepository.Get((dailyDetailItem) => dailyDetailItem.DailyMasterId == id)
                .Where(dailyMasterItem => dailyMasterItem.IsActive.HasValue && dailyMasterItem.IsActive.Value).ToList();
        }

        public AuditDailyDetail GetDailyDetailById(int id)
        {
            return _auditDailyDetailRepository.OneOrDefault(t => t.Id == id);
        }

        public List<AuditDailyDetailViewModel> GetAllDailyDetailByFiscalYearId(int fiscalYearId, int? dailyDetailyear = null)
        {
            var data = _auditDailyDetailRepository.GetByFiscalYearId(fiscalYearId, dailyDetailyear);
            return Mapper.Map<List<AuditDailyDetail>, List<AuditDailyDetailViewModel>>(data);
        }

        public void SaveAuditTurnOverSequence(AuditTurnoverSequence auditTurnOverSequence)
        {
            auditTurnOverSequence.IsActive = true;
            _auditTurnOverSequenceRepository.Add(auditTurnOverSequence);
            _unitOfWork.Commit();
        }

        public void SaveDailyMaster(DailyMaster dailyMaster)
        {
            dailyMaster.IsActive = true;
            var turnOvrSequence = _auditTurnOverSequenceRepository.GetById(dailyMaster.AuditTurnoverSequenceId);
            dailyMaster.FromDate = turnOvrSequence.TurnOverDateFrom;
            dailyMaster.ThruDate = turnOvrSequence.TurnOverDateTo;
            _dailyMasterRepository.Add(dailyMaster);
            _unitOfWork.Commit();
        }

        public void SaveDailyDetail(AuditDailyDetail dailyDetail)
        {
            if (dailyDetail.Id > 0)
            {
                _auditDailyDetailRepository.Update(dailyDetail);
            }
            else
            {
                dailyDetail.IsActive = true;
                _auditDailyDetailRepository.Add(dailyDetail);
            }
            _unitOfWork.Commit();
        }

        public void SaveFiscalYear(AuditFiscalYear auditFiscalYear)
        {
            auditFiscalYear.IsActive = true;
            _auditFiscalYearRepository.Add(auditFiscalYear);
            _unitOfWork.Commit();
        }

        public void EditAuditTurnOverSequence(AuditTurnoverSequence auditTurnoverSequence)
        {
            auditTurnoverSequence.IsActive = true;
            _auditTurnOverSequenceRepository.Update(auditTurnoverSequence);
            _unitOfWork.Commit();
        }

        public void EditDailyMaster(DailyMaster dailyMaster)
        {
            dailyMaster.IsActive = true;
            var result = _dailyMasterRepository.GetById(dailyMaster.Id);
            result.FromDate = dailyMaster.FromDate.HasValue ? dailyMaster.FromDate : default(DateTime?);
            result.ThruDate = dailyMaster.ThruDate.HasValue ? dailyMaster.ThruDate : default(DateTime?);
            result.FromReceipt = dailyMaster.FromReceipt;
            result.ThruReceipt = dailyMaster.ThruReceipt;
            result.CheckDollars = dailyMaster.CheckDollars;
            result.CurrencyDollars = dailyMaster.CurrencyDollars;
            result.CashDrawerDollars = dailyMaster.CashDrawerDollars;
            result.CoinDollars = dailyMaster.CoinDollars;
            // _dailyMasterRepository.Update(dailyMaster);
            _unitOfWork.Commit();
        }

        public AuditTurnoverSequence GetAuditTurnOverSequence(int id)
        {
            return _auditTurnOverSequenceRepository.GetById(id);
        }

        public void EditFiscalYear(AuditFiscalYear auditFiscalYear)
        {
            auditFiscalYear.IsActive = true;
            _auditFiscalYearRepository.Update(auditFiscalYear);
            _unitOfWork.Commit();
        }

        public void DeleteFiscalYear(AuditFiscalYear auditFiscalYear)
        {
            auditFiscalYear.IsActive = false;
            _auditFiscalYearRepository.Update(auditFiscalYear);
            _unitOfWork.Commit();
        }

        public void DeleteTurnOverSequence(AuditTurnoverSequence auditTurnoverSequence)
        {
            auditTurnoverSequence.IsActive = false;
            _auditTurnOverSequenceRepository.Update(auditTurnoverSequence);
            _unitOfWork.Commit();
        }

        public AuditFiscalYear GetAuditFiscalYear(int id)
        {
            return _auditFiscalYearRepository.GetById(id);
        }

        public List<AuditTurnoverSequence> GetAllTurnOverSequenceByAuditFiscalYearId(int id)
        {
            return _auditTurnOverSequenceRepository
                   .Get((audit) => audit.AuditFiscalYearId == id)
                   .Where(audit => audit.IsActive.HasValue && audit.IsActive.Value).ToList();
        }

        public List<DailyDetailReportGroupedByTaxYearViewModel> GetDailyDetailReport(DailyDetailReportFiltersViewModel filter)
        {
            var report = new List<DailyDetailReportGroupedByTaxYearViewModel>();
            var dailyDetailData = _auditDailyDetailRepository.GetByFiscalYearId(filter.FiscalYearId
                , filter.TaxYearFrom, filter.TaxYearTo
                , filter.EntryDateFrom, filter.EntryDateTo).OrderBy(t=>t.DailyMaster.EntryDate).ToList();

            var dailyDetailReportItems = Mapper.Map<List<AuditDailyDetail>, List<DailyDetailReportItemViewModel>>(dailyDetailData);

            var beginningBalances = _fiscalYearBeginningBalanceRepository.GetAll(filter.FiscalYearId, dailyDetailData.Select(t => t.TaxYear).ToList());
            foreach (var item in dailyDetailReportItems)
            {
                if (beginningBalances.Any(t => t.Year == item.TaxYear))
                    item.BeginningBalance = beginningBalances.FirstOrDefault(t => t.Year == item.TaxYear).BeginningBalance;
            }

            dailyDetailReportItems.GroupBy(t => t.TaxYear).ToList().ForEach(group =>
            {
                report.Add(new DailyDetailReportGroupedByTaxYearViewModel() { TaxYear = group.Key, Items = group.ToList() });
            });

            return report;
        }
    }
}