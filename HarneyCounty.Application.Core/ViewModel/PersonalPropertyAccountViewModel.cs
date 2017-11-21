using HarneyCounty.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarneyCounty.Application.Core.ViewModel
{
    public class PersonalPropertyAccountViewModel : AccountMasterDetailsViewModel
    {
        [Display(Name = "Address")]
        public string OwnerAdrsNameLine1 { get; set; }

        [Display(Name = "Address")]
        public string OwnerAdrsLine2 { get; set; }

        [Display(Name = "Address")]
        public string OwnerAdrsLine3 { get; set; }

        [Display(Name = "ZIP")]
        public new string SitusZipCode { get; set; }

        [Display(Name = "ADDRESS")]
        public string ZipCode { get; set; }

        [Display(Name ="Bus Type")]
        public string BusType { get; set; }

        [Display(Name = "Real Acct")]
        public new string AcctNmbr01431 { get; set; }

        [Display(Name = "JV#")]
        public JournalVoucher JournalVoucher { get; set; }

        public string ReturnFiledStatus { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateReturnFiled { get; set; }

        public string WorkedStatus { get; set; }

        public decimal? PpLine1Total { get; set; }

        public decimal? PpLine2Total { get; set; }

        public decimal? PpLine3Total { get; set; }

        public decimal? PpLine4Total { get; set; }

        public decimal? PpLine5Total { get; set; }

        public decimal? PpLine6Total { get; set; }
        
        public decimal? MaximumAssessedValue { get; set; }

        public decimal? TotalExceptions { get; set; }

        public decimal? TaxableAssessedValue { get; set; }

        public decimal? AcctExmpTotal { get; set; }

        public decimal? AcctSpecAses { get; set; }
        #region Composite Props



        #endregion Composite Props
    }
}
