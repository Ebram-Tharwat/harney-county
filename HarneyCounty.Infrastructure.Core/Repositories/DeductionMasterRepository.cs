using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Infrastructure.Core.DAL;
using HarneyCounty.Infrastructure.Core.Interfaces;

namespace HarneyCounty.Infrastructure.Core.Repositories
{
    public class DeductionMasterRepository : EFRepository<DeductionMaster>, IDeductionMasterRepository
    {
        public DeductionMasterRepository(HarneyCountyDbContext dbContext) : base(dbContext)
        {
        }
    }
}