﻿namespace HarneyCounty.Application.Core
{
    public class PagingInfo
    {
        public int PageIndex { get { return PageNumber - 1; } }

        public int PageNumber { get; set; }

        public int Total { get; set; }
    }
}