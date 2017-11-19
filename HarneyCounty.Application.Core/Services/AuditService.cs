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
        private readonly IRepository<AuditFiscalYear> _repository;
        private readonly IUnitOfWork _unitOfWork;
        public AuditService(IRepository<AuditFiscalYear> repository,IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }
        public List<AuditFiscalYear> GetAllAuditFiscalYears()
        {
            var result = _repository.GetAll().Where(f=>f.IsActive.HasValue && f.IsActive.Value).ToList();
            return result;
        }

        public void SaveFiscalYear(AuditFiscalYear auditFiscalYear)
        {
            auditFiscalYear.IsActive = true;
            _repository.Add(auditFiscalYear);
            _unitOfWork.Commit();
        }
        public void EditFiscalYear(AuditFiscalYear auditFiscalYear)
        {
            auditFiscalYear.IsActive = true;
            _repository.Update(auditFiscalYear);
            _unitOfWork.Commit();
        }
        public void DeleteFiscalYear(AuditFiscalYear auditFiscalYear)
        {
            auditFiscalYear.IsActive = false;
            _repository.Update(auditFiscalYear);
            _unitOfWork.Commit();
        }

        public AuditFiscalYear GetAuditFiscalYear(int id)
        {
            return _repository.GetById(id);
        }
    }
}
