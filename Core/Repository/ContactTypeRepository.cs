using Core.DB;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace Core.Repository
{
    public class ContactTypeRepository : IRepository<ContactType>
    {
        #region Fields&Properties

        private DBManager db;

        #endregion

        #region Constructors

        public ContactTypeRepository()
        {
            db = DBManager.GetInstance();
        }

        #endregion

        #region RepositoryItems

        public IEnumerable<ContactType> GetList()
        {
            var ds = db.ExecuteReader("select * from ContactTypes");

            var contacttypes = new List<ContactType>();

            foreach (DataRow row in (ds.Tables[0].Rows))
            {
                var contactType = new ContactType();

                contactType.ContactTypeId = (Guid)row[0];
                contactType.Name = row[1].ToString();

                contacttypes.Add(contactType);
            }

            return contacttypes;
        }

        public ContactType Get(Guid id)
        {
            var parameters = new List<Tuple<string, object>>
            {
                new Tuple<string, object>("contacttypeid", id)
            };

            var ds = db.ExecuteReader("select * from ContactTypes where ContactTypeId = @contacttypeid", parameters.ToArray());

            var contactType = new ContactType();

            DataRow row = ds.Tables[0].Rows[0];

            contactType.ContactTypeId = (Guid)row[0];
            contactType.Name = row[1].ToString();

            return contactType;
        }

        public void Create(ContactType item)
        {
            var parameters = new List<Tuple<string, object>>
            {
                new Tuple<string, object>("contacttypeid", item.ContactTypeId),
                new Tuple<string, object>("name", item.Name)
            };

            db.ExecuteCommand("insert into  ContactTypes values(" +
                                      "@contacttypeid, @name)", parameters.ToArray());
        }

        public void Update(ContactType item)
        {
            var parameters = new List<Tuple<string, object>>
            {
                new Tuple<string, object>("contacttypeid", item.ContactTypeId),
                new Tuple<string, object>("name", item.Name)
            };

            db.ExecuteCommand("update ContactTypes set " +
                                      "Name = @name where ContactTypeId = @contacttypeid", parameters.ToArray());
        }

        public void Delete(Guid id)
        {
            var parameters = new List<Tuple<string, object>>
            {
                new Tuple<string, object>("contacttypeid", id)
            };

            db.ExecuteCommand("delete from ContactTypes where ContactTypeId = @contacttypeid", parameters.ToArray());
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
