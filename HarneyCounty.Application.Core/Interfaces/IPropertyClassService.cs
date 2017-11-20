using HarneyCounty.Domain.Core.ViewModel;
using System.Collections.Generic;

namespace HarneyCounty.Application.Core.Interfaces
{
    public interface IPropertyClassService
    {
        List<PropertyClassBasicInfo> GetDistinctPropsInfo();
    }
}