using HarneyCounty.Application.Core.ViewModel.Payroll;
using System.Collections.Generic;

namespace HarneyCounty.Application.Core.Interfaces
{
    public interface IEmployeePayHrsHistoryService
    {
        List<PayHrsHistoryViewModel> GetEmployeePayHistoryListByEmpNumber(decimal empNumber);

        EmployeePayhistoryFullDetailsViewModel GetEmployeePayHistoryFullDetails(int payhistoryId);
    }
}