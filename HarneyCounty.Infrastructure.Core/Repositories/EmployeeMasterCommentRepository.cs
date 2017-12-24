using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Infrastructure.Core.DAL;
using HarneyCounty.Infrastructure.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace HarneyCounty.Infrastructure.Core.Repositories
{
    public class EmployeeMasterCommentRepository : EFRepository<EmployeeMasterComment>, IEmployeeMasterCommentRepository
    {
        public EmployeeMasterCommentRepository(HarneyCountyDbContext dbContext) : base(dbContext)
        {
        }

        public List<EmployeeMasterComment> GetEmployeeCommentsByEmpNumber(decimal empNumber)
        {
            return _dbContext.EmployeeMasterComments
                .Where(t => t.EmployeeNumber == empNumber).ToList();
        }
    }
}