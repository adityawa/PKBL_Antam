using System;
using System.Collections.Generic;
using System.Text;

namespace PKBL.Domain.Results
{
    public class ResultList<T>
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<T> data { get; set; }
        public string error { get; set; }
        public ResultList()
        {
            data = new List<T>();
            error = null;
        }
    }
}