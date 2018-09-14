using Core.DB;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace Core.Repository
{
    public class UserRepository : IRepository<User>
    {
        #region Fields&Properties

        private DBManager db;

        #endregion

        #region Constructors

        public UserRepository()
        {
            db = DBManager.GetInstance();
        }

        #endregion

        #region RepositoryItems

        public IEnumerable<User> GetList()
        {
            var ds = db.ExecuteReader("select * from Users");

            var users = new List<User>();

            foreach (DataRow row in (ds.Tables[0].Rows))
            {
                var user = new User();

                user.UserId = (Guid)row[0];
                user.FIO = row[1].ToString();
                user.Login = row[2].ToString();
                user.Password = row[3].ToString();
                user.RegisterDate = (DateTime)row[4];
                user.LastLoginDate = (DateTime)row[5];

                using (IRepository<Group> groupRep = new GroupRepository())
                {
                    var groupId = row[6];
                    if (groupId != DBNull.Value)
                        user.Group = groupRep.Get((System.Guid)groupId);
                }

                using (IRepository<GroupPermission> groupPermissionRep = new GroupPermissionRepository())
                {
                    var groupPermissionId = row[7];
                    if (groupPermissionId != DBNull.Value)
                        user.GroupPermission = groupPermissionRep.Get((System.Guid)groupPermissionId);
                }

                user.UserAvatar = (byte[])(row[8] == DBNull.Value ? null : row[8]);

                users.Add(user);
            }

            return users;
        }

        public User Get(Guid id)
        {
            var parameters = new List<Tuple<string, object>>
            {
                new Tuple<string, object>("userid", id)
            };

        restart:
            var ds = db.ExecuteReader("select * from Users where UserId = @userid", parameters.ToArray());

            var user = new User();

            try
            {
                DataRow row = ds.Tables[0].Rows[0];

                user.UserId = (Guid)row[0];
                user.FIO = row[1].ToString();
                user.Login = row[2].ToString();
                user.Password = row[3].ToString();
                user.RegisterDate = (DateTime)row[4];
                user.LastLoginDate = (DateTime)row[5];

                var groupId = row[6];
                if (groupId != DBNull.Value)
                    using (IRepository<Group> groupRep = new GroupRepository())
                    {
                        user.Group = groupRep.Get((System.Guid)groupId);
                    }

                var groupPermissionId = row[7];
                if (groupPermissionId != DBNull.Value)
                    using (IRepository<GroupPermission> groupPermissionRep = new GroupPermissionRepository())
                    {
                        user.GroupPermission = groupPermissionRep.Get((System.Guid)groupPermissionId);
                    }

                user.UserAvatar = (byte[])(row[8] == DBNull.Value ? null : row[8]);
            }
            catch
            {
                goto restart;
            }

            return user;
        }

        public void Update(Entities.User item)
        {
            var parameters = new List<Tuple<string, object>>
            {
                new Tuple<string, object>("userid", item.UserId),
                new Tuple<string, object>("fio", item.FIO),
                new Tuple<string, object>("login", item.Login),
                new Tuple<string, object>("password", item.Password),
                new Tuple<string, object>("registerdate", item.RegisterDate),
                new Tuple<string, object>("lastlogindate", item.LastLoginDate),
                new Tuple<string, object>("groupid", (object)(item.Group == null ? System.Guid.Empty : item.Group.GroupId)),
                new Tuple<string, object>("grouppermissionid", (object)(item.GroupPermission == null ? System.Guid.Empty : item.GroupPermission.GroupPermissionId)),
                new Tuple<string, object>("useravatar", item.UserAvatar)
            };

            db.ExecuteCommand("update Users set " +
                                      "FIO = @fio, Login = @login, " +
                                      "Password = @password, RegisterDate = @registerdate, " +
                                      "LastLoginDate = @lastlogindate, GroupId = @groupid, " +
                                      "GroupPermissionId = @grouppermissionid, UserAvatar = @useravatar " +
                                      "where UserId = @userid", parameters.ToArray());
        }

        public void Create(User item)
        {
            var parameters = new List<Tuple<string, object>>
            {
                new Tuple<string, object>("userid", item.UserId),
                new Tuple<string, object>("fio", item.FIO),
                new Tuple<string, object>("login", item.Login),
                new Tuple<string, object>("password", item.Password),
                new Tuple<string, object>("registerdate", item.RegisterDate),
                new Tuple<string, object>("lastlogindate", item.LastLoginDate),
                new Tuple<string, object>("groupid", item.Group.GroupId),
                new Tuple<string, object>("grouppermissionid", item.GroupPermission.GroupPermissionId)
            };

            db.ExecuteCommand("insert into Users values(" +
                                      "@userid, @fio, @login, @password, @registerdate, " +
                                      "@lastlogindate, @groupid, @grouppermissionid)", parameters.ToArray());
        }

        public void Delete(Guid id)
        {
            var parameters = new List<Tuple<string, object>>
            {
                new Tuple<string, object>("userid", id)
            };

            db.ExecuteCommand("delete from Users where UserId = @userid", parameters.ToArray());
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
