using HarneyCounty.Application.Core.Contracts.Paging;
using HarneyCounty.Application.Core.ViewModel.Payroll;
using System.Collections.Generic;

namespace HarneyCounty.Application.Core.Interfaces
{
    public interface IEmployeeMasterService
    {
        List<EmployeeMasterViewModel> SearchForEmployees(string firstName, string lastName, string status, PagingInfo pagingInfo);

        EmployeeMasterViewModel GetById(int id);

        Dictionary<string, string> GetEmployeeStatusesDic();
    }
}