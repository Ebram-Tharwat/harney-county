using HarneyCounty.Domain.Core.Models;
using System.Collections.Generic;

namespace HarneyCounty.Infrastructure.Core.Interfaces
{
    public interface IEmployeePayHrsHistoryRepository : IRepository<EmployeePayHrsHistory>
    {
        List<EmployeePayHrsHistory> GetEmployeePayHrsHistoryByEmpNumber(decimal empNumber);
    }
}