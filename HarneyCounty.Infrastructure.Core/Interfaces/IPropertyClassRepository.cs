using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Domain.Core.ViewModel;
using System.Collections.Generic;

namespace HarneyCounty.Infrastructure.Core.Interfaces
{
    public interface IPropertyClassRepository : IRepository<PropertyClass>
    {
        PropertyClass GetByPropertyClass(string propertyClass);

        List<string> GetDistinctPropertyClasses();

        List<PropertyClassBasicInfo> GetDistinctPropertyClassesInfo();
    }
}