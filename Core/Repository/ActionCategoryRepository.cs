using Core.DB;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace Core.Repository
{
    public class ActionCategoryRepository : IRepository<ActionCategory>
    {
        #region Fields&Properties

        private DBManager db;

        #endregion

        #region Constructors

        public ActionCategoryRepository()
        {
            db = DBManager.GetInstance();
        }

        #endregion

        #region RepositoryItems

        public IEnumerable<ActionCategory> GetList()
        {
            restart:
            var ds = db.ExecuteReader("select * from ActionCategories");

            var actioncategories = new List<ActionCategory>();

            try
            {
                foreach (DataRow row in (ds.Tables[0].Rows))
                {
                    var actioncategory = new ActionCategory();

                    actioncategory.ActionCategoryId = (Guid)row[0];
                    actioncategory.Name = row[1].ToString();
                    actioncategory.Priority = (int)row[2];

                    actioncategories.Add(actioncategory);
                }
            }
            catch
            {
                goto restart;
            }

            return actioncategories;
        }

        public ActionCategory Get(Guid id)
        {
            var parameters = new List<Tuple<string, object>>
            {
                new Tuple<string, object>("actioncategoryid", id)
            };

        restart:
            var ds = db.ExecuteReader("select * from ActionCategories where ActionCategoryId = @actioncategoryid", parameters.ToArray());

            var actioncategory = new ActionCategory();

            try
            {
                DataRow row = ds.Tables[0].Rows[0];

                actioncategory.ActionCategoryId = (Guid)row[0];
                actioncategory.Name = row[1].ToString();
                actioncategory.Priority = (int)row[2];
            }
            catch
            {
                goto restart;
            }

            return actioncategory;
        }

        public void Create(ActionCategory item)
        {
            var parameters = new List<Tuple<string, object>>
            {
                new Tuple<string, object>("actioncategoryid", item.ActionCategoryId),
                new Tuple<string, object>("name", item.Name),
                new Tuple<string, object>("priority",item.Priority)
            };

            db.ExecuteCommand("insert into  ActionCategories values(" +
                                      "@actioncategoryid, @name, @priority)", parameters.ToArray());
        }

        public void Update(ActionCategory item)
        {
            var parameters = new List<Tuple<string, object>>
            {
                new Tuple<string, object>("actioncategoryid", item.ActionCategoryId),
                new Tuple<string, object>("name", item.Name),
                new Tuple<string, object>("priority",item.Priority)
            };

            db.ExecuteCommand("update ActionCategories set " +
                                      "Name = @name, Priority = @priority " +
                                      "where ActionCategoryId = @actioncategoryid", parameters.ToArray());
        }

        public void Delete(Guid id)
        {
            var parameters = new List<Tuple<string, object>>
            {
                new Tuple<string, object>("actioncategoryid", id)
            };

            db.ExecuteCommand("delete from ActionCategories where ActionCategoryId = @actioncategoryid", parameters.ToArray());
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
