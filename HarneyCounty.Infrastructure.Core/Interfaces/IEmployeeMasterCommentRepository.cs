using HarneyCounty.Domain.Core.Models;
using System.Collections.Generic;

namespace HarneyCounty.Infrastructure.Core.Interfaces
{
    public interface IEmployeeMasterCommentRepository : IRepository<EmployeeMasterComment>
    {
        List<EmployeeMasterComment> GetEmployeeCommentsByEmpNumber(decimal empNumber);
    }
}