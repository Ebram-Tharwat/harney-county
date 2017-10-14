﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarneyCounty.Application.Core.Contracts
{
    public class SearchCriteria
    {
        //ToDo ask spud about Map # / Spec name of the columns in the database

        [Display(Name = "Account Number")]
        public int? AccountNumber { get; set; }

        [Range(1900, 2030)]
        public int Year { get; set; }

        public string OwnerName { get; set; }

        [StringLength(6)]
        public string SitusNumber { get; set; }

        [StringLength(3)]
        public string SitusNumberSuffix { get; set; }

        [MaxLength(2)]
        public string SitusDirectory { get; set; }

        [StringLength(10)]
        public string SitusZipCode { get; set; }

        [StringLength(4)]
        public string SubDivCode { get; set; }

        [Range(0, 999)]
        public int? LotNumber { get; set; }

        [Range(0, 999)]
        public int? BlockNumber { get; set; }

        [MaxLength(8)]
        public string XNmbr { get; set; }

        [Range(0, 999999)]
        public int? MobileHomeId { get; set; }

        [StringLength(15)]
        public string MobHomeMnfr { get; set; }

        [StringLength(15)]
        public string MHSerial { get; set; }

        [MaxLength(6)]
        public string CodeArea { get; set; }

        [MaxLength(4)]
        public string PropertyClass { get; set; }
    }
}
