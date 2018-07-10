using System.ComponentModel.DataAnnotations;

namespace HarneyCounty.Application.Core.ViewModel.Audit
{
    public class AuditDailyDetailViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Tax year")]
        public int TaxYear { get; set; }

        [Display(Name = "Curr Rcpts")]
        public decimal? CurrRcpts { get; set; }

        [Display(Name = "State %")]
        public decimal? StatePercentage { get; set; }

        [Display(Name = "Penalities")]
        public decimal? Penalities { get; set; }

        [Display(Name = "Refunds nsf")]
        public decimal? RefundsNsf { get; set; }

        [Display(Name = "12 %")]
        public decimal? C12PercentageInterest { get; set; }

        [Display(Name = "16 %")]
        public decimal? C16PercentageInterest { get; set; }

        [Display(Name = "Discount")]
        public decimal? Discount { get; set; }

        [Display(Name = "Losses to roll")]
        public decimal? LossesToRoll { get; set; }

        [Display(Name = "Gains to roll")]
        public decimal? GainsToRoll { get; set; }

        public int DailyMasterId { get; set; }

        public bool? IsActive { get; set; }

        #region Computed Properties

        [Display(Name = "Net Rcpts")]
        public decimal NetRcpts
        {
            get
            {
                if (this.CurrRcpts == 0)
                {
                    return (this.CurrRcpts ?? 0) - (this.StatePercentage ?? 0) - (this.Penalities ?? 0) - (this.RefundsNsf ?? 0);
                }
                else
                {
                    return (this.CurrRcpts ?? 0) - (this.StatePercentage ?? 0) - (this.Penalities ?? 0) + (this.RefundsNsf ?? 0);
                }
            }
        }

        public decimal NetTaxCr
        {
            get
            {
                return this.NetRcpts - (this.C12PercentageInterest ?? 0) - (this.C16PercentageInterest ?? 0) + (this.Discount ?? 0);
            }
        }

        public decimal NetRollChg
        {
            get
            {
                return this.NetTaxCr  + (this.GainsToRoll ?? 0);
            }
        }

        #endregion Computed Properties
    }
}