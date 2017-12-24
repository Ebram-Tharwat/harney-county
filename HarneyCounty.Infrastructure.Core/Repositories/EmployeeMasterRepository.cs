using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Infrastructure.Core.DAL;
using HarneyCounty.Infrastructure.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace HarneyCounty.Infrastructure.Core.Repositories
{
    public class EmployeeMasterRepository : EFRepository<EmployeeMaster>, IEmployeeMasterRepository
    {
        public EmployeeMasterRepository(HarneyCountyDbContext dbContext) : base(dbContext)
        {
        }

        public List<EmployeeMaster> SearchForEmployees(string firstName, string lastName, string status
            , out int resultCount, int pageNumber = 1, int pageSize = 50)
        {
            IQueryable<EmployeeMaster> query = _dbContext.EmployeeMasters;

            if (!string.IsNullOrWhiteSpace(firstName))
                query = query.Where(t => t.FirstName.ToLower() == firstName.ToLower());

            if (!string.IsNullOrWhiteSpace(lastName))
                query = query.Where(t => t.LastName.ToLower() == lastName.ToLower());

            if (!string.IsNullOrWhiteSpace(status))
                query = query.Where(t => t.ActiveDeleteTermSts.ToLower() == status.ToLower());

            if (pageNumber > 0)
            {
                var result = query.OrderBy(t => new { t.LastName, t.FirstName }).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                resultCount = query.Count();
                return result;
            }
            else
            {
                var result = query.OrderBy(t => new { t.LastName, t.FirstName }).ToList();
                resultCount = result.Count;
                return result;
            }
        }
    }
}