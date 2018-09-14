using System;

namespace Core.Entities
{
    public class Group
    {
        #region Fields&Properties

        public Guid GroupId { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid GroupCreator { get; set; }

        #endregion
    }
}
