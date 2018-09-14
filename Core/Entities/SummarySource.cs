using System;

namespace Core.Entities
{
    public class SummarySource
    {
        public DateTime Day { get; set; }
        public string UserName { get; set; }
        public decimal SummaryIncome { get; set; }
        public decimal SummaryConsumption { get; set; }
    }
}