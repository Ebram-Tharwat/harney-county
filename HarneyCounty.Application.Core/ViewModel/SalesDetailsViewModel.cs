using System.ComponentModel.DataAnnotations;

namespace HarneyCounty.Application.Core.ViewModel
{
    public class SalesDetailsViewModel
    {
        public int SalesAccountsId { get; set; }

        public string SaleIdentification { get; set; }

        [Display(Name = "Account #")]
        public string AcctNmbr { get; set; }

        [Display(Name = "Com")]
        public string CommentsExistStatus { get; set; }

        public int SalesMasterId { get; set; }

        [Display(Name = "Sale Date")]
        [DataType(DataType.Date)]
        public System.DateTime? SaleDate { get; set; }

        [Display(Name = "Buyer Name")]
        public string BuyerName { get; set; }

        [Display(Name = "Price")]
        public decimal? NetSalesPrice { get; set; }

        [Display(Name = "Ver")]
        public string ConditionCode { get; set; }

        [Display(Name = "Ratio")]
        public decimal? SaleRatio { get; set; }

        [Display(Name = "Mit")]
        public string MultiAccountFlag { get; set; }
    }
}