using HarneyCounty.Application.Core.Interfaces;
using HarneyCounty.Domain.Core.ViewModel;
using HarneyCounty.Infrastructure.Core.Interfaces;
using System.Collections.Generic;

namespace HarneyCounty.Application.Core.Services
{
    public class PropertyClassService : IPropertyClassService
    {
        private readonly IPropertyClassRepository _propertyClassRepository;

        public PropertyClassService(IPropertyClassRepository propertyClassRepository)
        {
            this._propertyClassRepository = propertyClassRepository;
        }

        public List<PropertyClassBasicInfo> GetDistinctPropsInfo()
        {
            return _propertyClassRepository.GetDistinctPropertyClassesInfo();
        }
    }
}