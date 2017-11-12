using HarneyCounty.Domain.Core.Models;

namespace HarneyCounty.Infrastructure.Core.Interfaces
{
    public interface IPropertyClassRepository : IRepository<PropertyClass>
    {
        PropertyClass GetByPropertyClass(string propertyClass);
    }
}