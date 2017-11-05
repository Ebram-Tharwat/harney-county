using HarneyCounty.Domain.Core.Models;

namespace HarneyCounty.Domain.Core.ViewModel
{
    public class MobileHomeData
    {
        public MobileHomeData()
        {
        }

        public MobileHomeData(AccountMasterFullDetail account)
        {
            Id = account.MobileHome_Id.Value;
            AsmtYear = account.AsmtYear;
            AcctNmbr = account.AcctNmbr;
            MobHomeRollType = account.MobHomeRollType;
            MobHomeSizeFlag = account.MobHomeSizeFlag;
            MobileHomeId = account.MobileHomeId;
            YearBuilt = account.YearBuilt;
            MobHomeWdth = account.MobHomeWdth;
            MobHomeLngth = account.MobHomeLngth;
            MhSerial = account.MhSerial;
            AcctNmbr01431 = account.AcctNmbr01431;
            MobHomeMnfr = account.MobHomeMnfr;
            XNmbr = account.XNmbr;
        }

        public int Id { get; set; }

        public decimal AsmtYear { get; set; }

        public string AcctNmbr { get; set; }

        public decimal? MobileHomeId { get; set; }

        public decimal? YearBuilt { get; set; }

        public decimal? MobHomeWdth { get; set; }

        public decimal? MobHomeLngth { get; set; }

        public string MobHomeRollType { get; set; }

        public string MobHomeSizeFlag { get; set; }

        public string MhSerial { get; set; }

        public string MobHomeMnfr { get; set; }

        public string AcctNmbr01431 { get; set; }

        public string XNmbr { get; set; }
    }
}