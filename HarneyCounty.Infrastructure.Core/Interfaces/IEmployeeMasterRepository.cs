using HarneyCounty.Domain.Core.Models;
using System.Collections.Generic;

namespace HarneyCounty.Infrastructure.Core.Interfaces
{
    public interface IEmployeeMasterRepository : IRepository<EmployeeMaster>
    {
        List<EmployeeMaster> SearchForEmployees(string firstName, string lastName, string status
            , out int resultCount, int pageNumber = 1, int pageSize = 50);
    }
}