using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LucidMarket.Services;
using LucidMarket.Abstractions;

namespace LucidMarket.Model
{
    public class Report : ClassExtent<Report>
    {
        public string ReportID { get; set; }
        public DateTime GeneratedDate { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }

        public Report(string reportId, DateTime generatedDate, string summary, string details)
        {
            ReportID = reportId;
            GeneratedDate = generatedDate;
            Summary = summary;
            Details = details;
        }
    }
}
