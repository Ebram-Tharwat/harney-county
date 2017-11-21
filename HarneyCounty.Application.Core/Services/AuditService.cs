using HarneyCounty.Application.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Infrastructure.Core.Interfaces;

namespace HarneyCounty.Application.Core.Services
{
    public class AuditService : IAuditService
    {
        private readonly IRepository<AuditFiscalYear> _auditFiscalYearRepository;
        private readonly IRepository<AuditTurnoverSequence> _auditTurnOverSequenceRepository;
        private readonly IUnitOfWork _unitOfWork;
        public AuditService(IRepository<AuditFiscalYear> repository,IRepository<AuditTurnoverSequence> auditTurnOverSequenceRepository,IUnitOfWork unitOfWork)
        {
            _auditFiscalYearRepository = repository;
            _auditTurnOverSequenceRepository = auditTurnOverSequenceRepository;
            _unitOfWork = unitOfWork;
        }
        public List<AuditFiscalYear> GetAllAuditFiscalYears()
        {
            var result = _auditFiscalYearRepository.GetAll().Where(f=>f.IsActive.HasValue && f.IsActive.Value).ToList();
            return result;
        }

        public void SaveAuditTurnOverSequence(AuditTurnoverSequence auditTurnOverSequence)
        {
            auditTurnOverSequence.IsActive = true;
            _auditTurnOverSequenceRepository.Add(auditTurnOverSequence);
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
