using System.ComponentModel.DataAnnotations;

namespace HarneyCounty.Application.Core.Contracts
{
    public enum SearchByType
    {
        [Display(Name = "Owner Name")]
        OwnerName = 1,

        [Display(Name = "Situs")]
        Situs,

        [Display(Name = "Subdivision, block or lot")]
        SubBlockLot,

        [Display(Name = "Block")]
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