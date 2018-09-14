using System;

namespace Core.Entities
{
    public class ActionCategory
    {
        public Guid ActionCategoryId { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }
    }
}
