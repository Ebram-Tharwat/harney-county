using HarneyCounty.Application.Core.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HarneyCounty.Web.ViewModel
{
    public class HomePageViewModel
    {
        public SearchCriteria SearchCriteria { get; set; }
        public List<Data> Data { get; set; }
        
    }

    public class Data
    {
        [Display(Name = "Account Number")]
        public int AccountNumber { get; set; }

        [Display(Name = "Owner Name")]
        public string OwnerName { get; set; }

        public string Flg { get; set; }

        public string MapId { get; set; }

        public string Prop { get; set; }

        public string Code { get; set; }

        public string Rl { get; set; }
    }

   
}