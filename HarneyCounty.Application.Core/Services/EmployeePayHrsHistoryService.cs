using HarneyCounty.Application.Core.Interfaces;
using HarneyCounty.Application.Core.ViewModel.Payroll;
using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Infrastructure.Core.Interfaces;
using System;
using System.Collections.Generic;

namespace HarneyCounty.Application.Core.Services
{
    public class EmployeePayHrsHistoryService : IEmployeePayHrsHistoryService
    {
        private readonly IEmployeePayHrsHistoryRepository _employeePayHrsHistoryRepository;
        private readonly IDeductionHistoryRepository _deductionHistoryRepository;

        public EmployeePayHrsHistoryService(IEmployeePayHrsHistoryRepository employeePayHrsHistoryRepository, IDeductionHistoryRepository deductionHistoryRepository)
        {
            this._employeePayHrsHistoryRepository = employeePayHrsHistoryRepository;
            this._deductionHistoryRepository = deductionHistoryRepository;
        }

        public List<PayHrsHistoryViewModel> GetEmployeePayHistoryListByEmpNumber(decimal empNumber)
        {
            var empPayHistory = _employeePayHrsHistoryRepository.GetEmployeePayHrsHistoryByEmpNumber(empNumber);
            return AutoMapper.Mapper.Map<List<EmployeePayHrsHistory>, List<PayHrsHistoryViewModel>>(empPayHistory);
        }

        public EmployeePayhistoryFullDetailsViewModel GetEmployeePayHistoryFullDetails(int payhistoryId)
        {
            var result = new EmployeePayhistoryFullDetailsViewModel();
            var empPayHistory = _employeePayHrsHistoryRepository.OneOrDefault(t => t.Id == payhistoryId);
            if (empPayHistory == null)
            {
                throw new NullReferenceException("Payhistory entity not found");
            }
            result.PayDetails = AutoMapper.Mapper.Map<EmployeePayHrsHistory, PayDetailsViewModel>(empPayHistory);
            result.HourDetails = AutoMapper.Mapper.Map<EmployeePayHrsHistory, HourDetailsViewModel>(empPayHistory);
            result.EmployeeNumber = (int)result.PayDetails.EmployeeNumber;
            result.PayDate = result.PayDetails.PayDate;

            var deductions = _deductionHistoryRepository.GetDeductionHistoryFullDetails(result.PayDetails.EmployeeNumber, result.PayDetails.PayDate);
            result.Deductions = AutoMapper.Mapper.Map<List<DeductionFullDetail>, List<DeductionDetailsViewModel>>(deductions);

            return result;
        }
    }
}