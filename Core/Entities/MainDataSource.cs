using System;

namespace Core.Entities
{
    public class MainDataSource
    {
        public DateTime ActionDate { get; set; }
        public string ActionTypeName { get; set; }
        public string ActionCategoryName { get; set; }
        public string UserName { get; set; }
        public decimal Summ { get; set; }
    }
}
