using Core.DB;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace Core.Repository
{
    public class ContactRepository : IRepository<Contact>
    {
        #region Fields&Properties

        private DBManager db;

        #endregion

        #region Constructors

        public ContactRepository()
        {
            db = DBManager.GetInstance();
        }

        #endregion

        #region RepositoryItems

        public IEnumerable<Contact> GetList()
        {
            var ds = db.ExecuteReader("select * from Contacts");

            var contacts = new List<Contact>();

            foreach (DataRow row in (ds.Tables[0].Rows))
            {
                var contact = new Contact();

                contact.ContactId = (System.Guid)row[0];

                using (IRepository<ContactType> ContactTypeRepository = new ContactTypeRepository())
                    contact.ContactType = ContactTypeRepository.Get((System.Guid)row[1]);

                contact.ContactName = row[2].ToString();
                contact.CreateDate = (DateTime)row[3];

                using (IRepository<Entities.User> UserRepository = new UserRepository())
                    contact.User = UserRepository.Get((System.Guid)row[4]);

                contacts.Add(contact);
            }

            return contacts;
        }

        public Contact Get(System.Guid id)
        {
            var parameters = new List<Tuple<string, object>>
            {
                new Tuple<string, object>("contactid", id)
            };

            var ds = db.ExecuteReader("select * from Contacts where ContactId = @contactid", parameters.ToArray());

            var contact = new Contact();

            var row = ds.Tables[0].Rows[0];

            contact.ContactId = (System.Guid)row[0];

            using (IRepository<ContactType> ContactTypeRepository = new ContactTypeRepository())
                contact.ContactType = ContactTypeRepository.Get((System.Guid)row[1]);

            contact.ContactName = row[2].ToString();
            contact.CreateDate = (DateTime)row[3];

            using (IRepository<Entities.User> UserRepository = new UserRepository())
                contact.User = UserRepository.Get((System.Guid)row[4]);


            return contact;
        }

        public void Create(Contact item)
        {
            var parameters = new List<Tuple<string, object>>
            {
                new Tuple<string, object>("contactid", item.ContactId),
                new Tuple<string, object>("contacttypeid", item.ContactType.ContactTypeId),
                new Tuple<string, object>("contactname", item.ContactName),
                new Tuple<string, object>("createdate", item.CreateDate),
                new Tuple<string, object>("userid", item.User.UserId)
            };

            db.ExecuteCommand("insert into Contacts values(" +
                              "@contactid, @contacttypeid, @contactname, @createdate, @userid)", parameters.ToArray());
        }

        public void Update(Contact item)
        {
            var parameters = new List<Tuple<string, object>>
            {
                new Tuple<string, object>("contactid", item.ContactId),
                new Tuple<string, object>("contacttypeid", item.ContactType.ContactTypeId),
                new Tuple<string, object>("contactname", item.ContactName),
                new Tuple<string, object>("createdate", item.CreateDate),
                new Tuple<string, object>("userid", item.User.UserId)
            };

            db.ExecuteCommand("update Contacts set" +
                              "ContactTypeId = @contacttypeid, ContactName = @contactname, " +
                              "CreateDate = @createdate, UserId = @userid" +
                              "where ContactId = @contactid", parameters.ToArray());
        }

        public void Delete(System.Guid id)
        {
            var parameters = new List<Tuple<string, object>>
            {
                new Tuple<string, object>("contactid", id)
            };

            db.ExecuteCommand("delete from Contacts where ContactId = @contactid", parameters.ToArray());
        }

        #endregion

        #region DisposableItems

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    //db.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
