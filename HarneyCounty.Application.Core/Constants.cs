namespace HarneyCounty.Application.Core
{
    public static class Constants
    {
        public const string ExcelFilesMimeType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
        public const string FiscalYearBeginingBalancesTemplateExcelFileName = "Beginning Balances of {0}.xlsx";
        public const string FiscalYearDailyDetailTemplateExcelFileName = "Daily Detail of {0}.xlsx";
        public const string ShortDateFormat = "MM-dd-yyyy";

        public const string SpeciallyAssessedAccountFlag = "Y";

        public static class RollType
        {
            public const string RealProperty = "R";
            public const string MobileHome = "M";
            public const string Utilities = "U";
            public const string PersonalProperty = "P";
        }

        public static class LegalCommentType
        {
            public const string Comment = "C";
            public const string Legal = "L";
        }

        public static class LandAssessmentType
        {
            public const string Special = "S";
            public const string Market = "M";
        }

        public static class EmployeeStatus
        {
            public const string Active = "A";
            public const string Deleted = "D";
            public const string Terminated = "T";
        }
    }
}