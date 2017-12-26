using HarneyCounty.Application.Core.Interfaces;
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
        private readonly IRepository<AuditDailyDetail> _auditDailyDetailRepository;
        private readonly IUnitOfWork _unitOfWork;

        public AuditService(IRepository<AuditFiscalYear> repository, IRepository<AuditTurnoverSequence> auditTurnOverSequenceRepository, IRepository<DailyMaster> dailyMasterRepository, IRepository<AuditDailyDetail> auditDailyDetailRepository, IUnitOfWork unitOfWork)
        {
            _auditFiscalYearRepository = repository;
            _auditTurnOverSequenceRepository = auditTurnOverSequenceRepository;
            _dailyMasterRepository = dailyMasterRepository;
            _auditDailyDetailRepository = auditDailyDetailRepository;
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
    }
}