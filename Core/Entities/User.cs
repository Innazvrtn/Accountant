using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public class User
    {
        #region Fields&Properties

        public Guid UserId { get; set; }
        public string FIO { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime LastLoginDate { get; set; }
        public Group Group { get; set; }
        public GroupPermission GroupPermission { get; set; }
        public List<Contact> Contacts { get; set; }
        public byte[] UserAvatar { get; set; }

        #endregion
    }
}
