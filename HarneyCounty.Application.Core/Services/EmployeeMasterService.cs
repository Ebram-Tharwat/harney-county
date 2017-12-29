using HarneyCounty.Application.Core.Contracts.Paging;
using HarneyCounty.Application.Core.Interfaces;
using HarneyCounty.Application.Core.ViewModel.Payroll;
using HarneyCounty.Common;
using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Infrastructure.Core.Interfaces;
using System.Collections.Generic;

namespace HarneyCounty.Application.Core.Services
{
    public class EmployeeMasterService : IEmployeeMasterService
    {
        private readonly IEmployeeMasterRepository _employeeMasterRepository;
        private readonly IEmployeeMasterCommentRepository _employeeMasterCommentRepository;
        private readonly IEmployeePayHrsHistoryService _employeePayHrsHistoryService;
        private readonly IDeductionHistoryService _deductionHistoryService;

        public EmployeeMasterService(IEmployeeMasterRepository employeeMasterRepository, IEmployeeMasterCommentRepository employeeMasterCommentRepository
            , IEmployeePayHrsHistoryService employeePayHrsHistoryService, IDeductionHistoryService deductionHistoryService)
        {
            this._employeeMasterRepository = employeeMasterRepository;
            this._employeeMasterCommentRepository = employeeMasterCommentRepository;
            this._employeePayHrsHistoryService = employeePayHrsHistoryService;
            this._deductionHistoryService = deductionHistoryService;
        }

        public List<EmployeeMasterViewModel> SearchForEmployees(string firstName, string lastName, string status, PagingInfo pagingInfo)
        {
            int resultCount = 0;
            var result = _employeeMasterRepository.SearchForEmployees(firstName, lastName, status, out resultCount, pagingInfo.PageNumber, AppSettings.PageSize);
            pagingInfo.Total = resultCount;

            return AutoMapper.Mapper.Map<List<EmployeeMaster>, List<EmployeeMasterViewModel>>(result);
        }

        public EmployeeMasterViewModel GetById(int id, PayHistoryFilterViewModel filter = null)
        {
            var employee = _employeeMasterRepository.GetById(id);
            var result = AutoMapper.Mapper.Map<EmployeeMaster, EmployeeMasterViewModel>(employee);

            var empComments = _employeeMasterCommentRepository.GetEmployeeCommentsByEmpNumber(employee.EmployeeNumber);
            result.Comments = AutoMapper.Mapper.Map<List<EmployeeMasterComment>, List<EmployeeMasterCommentViewModel>>(empComments);
            result.PayHistory = _employeePayHrsHistoryService.GetEmployeePayHistoryListByEmpNumber(employee.EmployeeNumber);
            if (filter == null)
                result.Deductions = _deductionHistoryService.GetDeductionHistoryFullDetails(employee.EmployeeNumber, null, null);
            else
                result.Deductions = _deductionHistoryService.GetDeductionHistoryFullDetails(employee.EmployeeNumber, filter.StartDate, filter.EndDate, filter.DeductionCode);

            return result;
        }

        public Dictionary<string, string> GetEmployeeStatusesDic()
        {
            return new Dictionary<string, string>()
            {
                {Constants.EmployeeStatus.Active, "Active" },
                {Constants.EmployeeStatus.Deleted, "Deleted" },
                {Constants.EmployeeStatus.Terminated, "Terminated" }
            };
        }
    }
}