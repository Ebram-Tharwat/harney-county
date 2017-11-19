using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Domain.Core.ViewModel;
using HarneyCounty.Infrastructure.Core.DAL;
using HarneyCounty.Infrastructure.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace HarneyCounty.Infrastructure.Core.Repositories
{
    public class CodeAreaRepository : EFRepository<CodeArea>, ICodeAreaRepository
    {
        public CodeAreaRepository(HarneyCountyDbContext dbContext) : base(dbContext)
        {
        }

        public List<CodeAreaBasicInfo> GetDistinctCodeAreasInfo()
        {
            return (from prop in _dbContext.CodeAreas
                    select new CodeAreaBasicInfo { Name = prop.CodeArea_.Trim(), Description = prop.CodeAreaDescription.Trim() })
                    .Distinct().ToList();
        }
    }
}