using System;
using System.Collections.Generic;
using System.Text;

namespace PKBL.Domain.Filters
{
    public class BaseFilter
    {
        public int draw { get; set; }
        public string Keyword { get; set; }
        public int InitialPage { get; set; }
        public int PageSize { get; set; }
        public string OrderBy { get; set; }
        public string SortOrder { get; set; }
    }
}
