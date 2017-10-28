using System.ComponentModel.DataAnnotations;

namespace HarneyCounty.Application.Core.Contracts
{
    public enum SearchByType
    {
        [Display(Name = "Owner Name")]
        OwnerName = 1,

        [Display(Name = "Situs")]
        Situs,

        [Display(Name = "Subdivision, Block or Lot")]
        SubBlockLot,

        [Display(Name = "Map")]
        Map,

        [Display(Name = "Manu Structure X-Num or Mobile Home ID")]
        XNumberOrMobileHomeId,

        [Display(Name = "MS Manuf or Serial #")]
        MobileHomeManufacturerOrMobileSerial,

        [Display(Name = "Property Class")]
        PropertyClass,

        [Display(Name = "Code Area")]
        CodeArea
    }
}