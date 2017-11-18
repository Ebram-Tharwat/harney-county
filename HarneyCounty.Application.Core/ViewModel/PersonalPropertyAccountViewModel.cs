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

        #region Composite Props



        #endregion Composite Props
    }
}
