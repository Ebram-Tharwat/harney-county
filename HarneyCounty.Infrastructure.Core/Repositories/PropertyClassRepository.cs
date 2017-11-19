using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Domain.Core.ViewModel;
using HarneyCounty.Infrastructure.Core.DAL;
using HarneyCounty.Infrastructure.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace HarneyCounty.Infrastructure.Core.Repositories
{
    public class PropertyClassRepository : EFRepository<PropertyClass>, IPropertyClassRepository
    {
        public PropertyClassRepository(HarneyCountyDbContext dbContext) : base(dbContext)
        {
        }

        public PropertyClass GetByPropertyClass(string propertyClass)
        {
            return _dbSet.FirstOrDefault(t => t.PropertyClass_.Trim() == propertyClass);
        }

        public List<string> GetDistinctPropertyClasses()
        {
            return (from prop in _dbContext.PropertyClasses
                    select prop.PropertyClass_.Trim())
                    .Distinct().ToList();
        }

        public List<PropertyClassBasicInfo> GetDistinctPropertyClassesInfo()
        {
            return (from prop in _dbContext.PropertyClasses
                    select new PropertyClassBasicInfo { Name = prop.PropertyClass_.Trim(), Description = prop.PropertyClassDescription.Trim() })
                    .Distinct().ToList();
        }
    }
}