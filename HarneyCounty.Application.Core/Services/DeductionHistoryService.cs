using HarneyCounty.Application.Core.Interfaces;
using HarneyCounty.Application.Core.ViewModel.Payroll;
using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Infrastructure.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HarneyCounty.Application.Core.Services
{
    public class DeductionHistoryService : IDeductionHistoryService
    {
        private readonly IDeductionHistoryRepository _deductionHistoryRepository;
        private readonly IDeductionMasterRepository _deductionMasterRepository;

        public DeductionHistoryService(IDeductionHistoryRepository deductionHistoryRepository, IDeductionMasterRepository deductionMasterRepository)
        {
            this._deductionHistoryRepository = deductionHistoryRepository;
            this._deductionMasterRepository = deductionMasterRepository;
        }

        public List<string> GetAllDeductionCodes()
        {
            return _deductionMasterRepository.GetAll().Select(t => t.DeductionCode.Trim()).ToList();
        }

        public List<DeductionDetailsViewModel> GetDeductionHistoryFullDetails(decimal employeeNumber, DateTime? payDate = null, string deductionCode = null)
        {
            var deductions = _deductionHistoryRepository.GetDeductionHistoryFullDetails(employeeNumber, payDate, deductionCode);
            return AutoMapper.Mapper.Map<List<DeductionFullDetail>, List<DeductionDetailsViewModel>>(deductions);
        }

        public List<DeductionDetailsViewModel> GetDeductionHistoryFullDetails(decimal employeeNumber, DateTime? startDate = null, DateTime? endDate = null, string deductionCode = null)
        {
            var deductions = _deductionHistoryRepository.GetDeductionHistoryFullDetails(employeeNumber, startDate, endDate, deductionCode);
            return AutoMapper.Mapper.Map<List<DeductionFullDetail>, List<DeductionDetailsViewModel>>(deductions);
        }
    }
}