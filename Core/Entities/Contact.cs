using System;

namespace Core.Entities
{
    public class Contact
    {
        #region Fields&Properties

        public Guid ContactId { get; set; }
        public ContactType ContactType { get; set; }
        public string ContactName { get; set; }
        public DateTime CreateDate { get; set; }
        public User User { get; set; }

        #endregion
    }
}
