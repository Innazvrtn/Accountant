using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DB;
using Core.Entities;

namespace Core.Repository
{
    public class ActionRepository : IRepository<Entities.Action>
    {
        #region Fields&Properties

        private DBManager db;

        #endregion

        #region Constructors

        public ActionRepository()
        {
            db = DBManager.GetInstance();
        }

        #endregion

        #region RepositoryItems

        public IEnumerable<Entities.Action> GetList()
        {
            //var ds = db.ExecuteReader("select * from Actions");
            var ds = db.ExecuteProcedure(ActionStrings.ActionList);

            var actions = new List<Entities.Action>();

            List<User> users = new List<User>();

            using (var userRep = new UserRepository())
                users = userRep.GetList().ToList();

            foreach (DataRow row in (ds.Tables[0].Rows))
            {
                var action = new Entities.Action();

                action.ActionId = (Guid)row[0];
                action.ActionDate = (DateTime)row[1];
                action.ActionType = new ActionType() { ActionTypeId = (Guid)row[2], Name = row[3].ToString() };
                //using (var userRep = new UserRepository())
                //    action.UserAction = userRep.Get((Guid)row[4]);
                //action.UserAction = new User() { UserId = (Guid)row[5], FIO = row[6].ToString(), Login = row[7].ToString(), Password = row[8].ToString(), RegisterDate = (DateTime)row[9], LastLoginDate = (DateTime)row[8],  };
                action.UserAction = users.FirstOrDefault(u => u.UserId == (Guid)row[4]);
                action.ActionCategory = new ActionCategory() { ActionCategoryId = (Guid)row[5], Name = row[6].ToString(), Priority = (int)row[7] };
                action.ActionComment = row[8].ToString();
                action.ActionSumm = (decimal)row[9];

                actions.Add(action);
            }

            return actions;
        }

        public Entities.Action Get(Guid id)
        {
            var parameters = new List<Tuple<string, object>>()
            {
                new Tuple<string, object>("actionid", id)
            };

            var row = db.ExecuteReader("select * from Actions where ActionId = @actionid", parameters.ToArray()).Tables[0].Rows[0];

            var action = new Entities.Action();

            action.ActionId = (Guid)row[0];
            action.ActionDate = (DateTime)row[1];

            using (var actiontypeRep = new ActionTypeRepository())
                action.ActionType = actiontypeRep.Get((Guid)row[2]);

            using (var userRep = new UserRepository())
                action.UserAction = userRep.Get((Guid)row[3]);

            using (var actioncategoryRep = new ActionCategoryRepository())
                action.ActionCategory = actioncategoryRep.Get((Guid)row[4]);

            action.ActionComment = row[5].ToString();
            action.ActionSumm = (decimal)row[6];

            return action;
        }

        public void Create(Entities.Action item)
        {
            var parameters = new List<Tuple<string, object>>
            {
                new Tuple<string, object>("actionid", item.ActionId),
                new Tuple<string, object>("actiondate", item.ActionDate),
                new Tuple<string, object>("actiontypeid", item.ActionType.ActionTypeId),
                new Tuple<string, object>("userid", item.UserAction.UserId),
                new Tuple<string, object>("actioncategoryid", item.ActionCategory.ActionCategoryId),
                new Tuple<string, object>("actioncomment", item.ActionComment),
                new Tuple<string, object>("actionsumm", item.ActionSumm)
            };

            db.ExecuteCommand("insert into Actions values (" +
                                      "@actionid, @actiondate, @actiontypeid, " +
                                      "@userid, @actioncategoryid, " +
                                      "@actioncomment, @actionsumm" +
                                      ")", parameters.ToArray());
        }

        public void Update(Entities.Action item)
        {
            var parameters = new List<Tuple<string, object>>
            {
                new Tuple<string, object>("actionid", item.ActionId),
                new Tuple<string, object>("actiondate", item.ActionDate),
                new Tuple<string, object>("actiontypeid", item.ActionType.ActionTypeId),
                new Tuple<string, object>("userid", item.UserAction.UserId),
                new Tuple<string, object>("actioncategoryid", item.ActionCategory.ActionCategoryId),
                new Tuple<string, object>("actioncomment", item.ActionComment),
                new Tuple<string, object>("actionsumm", item.ActionSumm)
            };

            db.ExecuteCommand("update Actions set " +
                                      "ActionDate = @actiondate, ActionTypeId = @actiontypeid, " +
                                      "UserId = @userid, ActionCategoryId = @actioncategoryid, " +
                                      "ActionComment = @actioncomment, ActionSumm = @actionsumm" +
                                      "where ActionId = @actionid", parameters.ToArray());
        }

        public void Delete(Guid id)
        {
            var parameters = new List<Tuple<string, object>>
            {
                new Tuple<string, object>("actionid", id)
            };

            db.ExecuteCommand("delete from Actions where ActionId = @actionid", parameters.ToArray());
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
