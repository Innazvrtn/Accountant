using Core.DB;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace Core.Repository
{
    public class ActionTypeRepository : IRepository<ActionType>
    {
        #region Fields&Properties

        private DBManager db;

        #endregion

        #region Constructors

        public ActionTypeRepository()
        {
            db = DBManager.GetInstance();
        }

        #endregion

        #region RepositoryItems

        public IEnumerable<ActionType> GetList()
        {
        restart:
            var ds = db.ExecuteReader("select * from ActionTypes");

            var actiontypes = new List<ActionType>();

            try
            {
                foreach (DataRow row in (ds.Tables[0].Rows))
                {
                    var actiontype = new ActionType();

                    actiontype.ActionTypeId = (Guid)row[0];
                    actiontype.Name = row[1].ToString();

                    actiontypes.Add(actiontype);
                }
            }
            catch
            {
                goto restart;
            }


            return actiontypes;
        }

        public ActionType Get(Guid id)
        {
            var parameters = new List<Tuple<string, object>>
            {
                new Tuple<string, object>("actiontypeid", id)
            };
        restart:
            var ds = db.ExecuteReader("select * from ActionTypes where ActionTypeId = @actiontypeid", parameters.ToArray());

            var actiontype = new ActionType();

            try
            {
                DataRow row = ds.Tables[0].Rows[0];

                actiontype.ActionTypeId = (Guid)row[0];
                actiontype.Name = row[1].ToString();
            }
            catch
            {
                goto restart;
            }

            return actiontype;
        }

        public void Create(ActionType item)
        {
            var parameters = new List<Tuple<string, object>>
            {
                new Tuple<string, object>("actiontypeid", item.ActionTypeId),
                new Tuple<string, object>("name", item.Name)
            };

            db.ExecuteCommand("insert into  ActionTypes values(" +
                                      "@actiontypeid, @name)", parameters.ToArray());
        }

        public void Update(ActionType item)
        {
            var parameters = new List<Tuple<string, object>>
            {
                new Tuple<string, object>("actiontypeid", item.ActionTypeId),
                new Tuple<string, object>("name", item.Name)
            };

            db.ExecuteCommand("update ActionTypes set " +
                                      "Name = @name where ActionTypeId = @actiontypeid", parameters.ToArray());
        }

        public void Delete(Guid id)
        {
            var parameters = new List<Tuple<string, object>>
            {
                new Tuple<string, object>("actiontypeid", id)
            };

            db.ExecuteCommand("delete from ActionTypes where ActionTypeId = @actiontypeid", parameters.ToArray());
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
