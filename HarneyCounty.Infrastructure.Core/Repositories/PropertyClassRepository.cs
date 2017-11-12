using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Infrastructure.Core.DAL;
using HarneyCounty.Infrastructure.Core.Interfaces;
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
    }
}