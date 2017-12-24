using HarneyCounty.Application.Core.Contracts.Paging;
using HarneyCounty.Application.Core.ViewModel.Employee;
using System.Collections.Generic;

namespace HarneyCounty.Application.Core.Interfaces
{
    public interface IEmployeeMasterService
    {
        List<EmployeeMasterViewModel> SearchForEmployees(string firstName, string lastName, string status, PagingInfo pagingInfo);

        Dictionary<string, string> GetEmployeeStatusesDic();
    }
}