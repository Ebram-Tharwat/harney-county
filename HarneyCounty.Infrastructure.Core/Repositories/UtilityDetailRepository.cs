using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Infrastructure.Core.DAL;
using HarneyCounty.Infrastructure.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarneyCounty.Infrastructure.Core.Repositories
{
    public class UtilityDetailRepository : EFRepository<UtilityDetail>, IUtilityDetailRepository
    {
        public UtilityDetailRepository(HarneyCountyDbContext dbContext) : base(dbContext)
        {
        }
    }
}
