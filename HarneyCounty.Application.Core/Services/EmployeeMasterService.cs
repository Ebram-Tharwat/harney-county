using HarneyCounty.Application.Core.Contracts.Paging;
using HarneyCounty.Application.Core.Interfaces;
using HarneyCounty.Application.Core.ViewModel.Employee;
using HarneyCounty.Common;
using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Infrastructure.Core.Interfaces;
using System.Collections.Generic;
using static HarneyCounty.Application.Core.Constants;

namespace HarneyCounty.Application.Core.Services
{
    public class EmployeeMasterService : IEmployeeMasterService
    {
        private readonly IEmployeeMasterRepository _employeeMasterRepository;
        private readonly IEmployeeMasterCommentRepository _employeeMasterCommentRepository;

        public EmployeeMasterService(IEmployeeMasterRepository employeeMasterRepository, IEmployeeMasterCommentRepository employeeMasterCommentRepository)
        {
            this._employeeMasterRepository = employeeMasterRepository;
            this._employeeMasterCommentRepository = employeeMasterCommentRepository;
        }

        public List<EmployeeMasterViewModel> SearchForEmployees(string firstName, string lastName, string status, PagingInfo pagingInfo)
        {
            int resultCount = 0;
            var result = _employeeMasterRepository.SearchForEmployees(firstName, lastName, status, out resultCount, pagingInfo.PageNumber, AppSettings.PageSize);
            pagingInfo.Total = resultCount;

            return AutoMapper.Mapper.Map<List<EmployeeMaster>, List<EmployeeMasterViewModel>>(result);
        }

        public EmployeeMasterViewModel GetById(int id)
        {
            var employee = _employeeMasterRepository.GetById(id);
            var result = AutoMapper.Mapper.Map<EmployeeMaster, EmployeeMasterViewModel>(employee);

            var empComments = _employeeMasterCommentRepository.GetEmployeeCommentsByEmpNumber(employee.EmployeeNumber);
            result.Comments = AutoMapper.Mapper.Map<List<EmployeeMasterComment>, List<EmployeeMasterCommentViewModel>>(empComments);

            return result;
        }

        public Dictionary<string, string> GetEmployeeStatusesDic()
        {
            return new Dictionary<string, string>()
            {
                {EmployeeStatus.Active, "Active" },
                {EmployeeStatus.Deleted, "Deleted" },
                {EmployeeStatus.Terminated, "Terminated" }
            };
        }
    }
}