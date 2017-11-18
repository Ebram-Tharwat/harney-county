using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Infrastructure.Core.DAL;
using HarneyCounty.Infrastructure.Core.Interfaces;
using System.Linq;

namespace HarneyCounty.Infrastructure.Core.Repositories
{
    public class PersonalPropFullDetailsRepository : EFRepository<PersonalPropFullDetail>, IPersonalPropFullDetailsRepository
    {
        public PersonalPropFullDetailsRepository(HarneyCountyDbContext dbContext) : base(dbContext)
        {
        }

        public PersonalPropFullDetail GetPersonalPropFullDetailsByYearAndAccountNumber(int year, string actNumber)
        {
            return _dbContext.PersonalPropFullDetails
                .FirstOrDefault(t => t.AsmtYear == year && t.AcctNmbr.Trim() == actNumber.Trim());
        }
    }
}