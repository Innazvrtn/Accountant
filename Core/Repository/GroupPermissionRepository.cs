using Core.DB;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace Core.Repository
{
    public class GroupPermissionRepository : IRepository<GroupPermission>
    {
        #region Fields&Properties

        private DBManager db;

        #endregion

        #region Constructors

        public GroupPermissionRepository()
        {
            db = DBManager.GetInstance();
        }

        #endregion

        #region RepositoryItems

        public IEnumerable<GroupPermission> GetList()
        {
            var ds = db.ExecuteReader("select * from GroupPermissions");

            var grouppermissions = new List<GroupPermission>();

            foreach (DataRow row in (ds.Tables[0].Rows))
            {
                var grouppermission = new GroupPermission();

                grouppermission.GroupPermissionId = (Guid)row[0];
                grouppermission.Name = row[1].ToString();

                grouppermissions.Add(grouppermission);
            }

            return grouppermissions;
        }

        public GroupPermission Get(Guid id)
        {
            var parameters = new List<Tuple<string, object>>
            {
                new Tuple<string, object>("grouppermissionid", id)
            };

            var ds = db.ExecuteReader("select * from GroupPermissions where GroupPermissionId = @grouppermissionid", parameters.ToArray());

            var grouppermission = new GroupPermission();

            DataRow row = ds.Tables[0].Rows[0];

            grouppermission.GroupPermissionId= (Guid)row[0];
            grouppermission.Name = row[1].ToString();

            return grouppermission;
        }

        public void Create(GroupPermission item)
        {
            var parameters = new List<Tuple<string, object>>
            {
                new Tuple<string, object>("grouppermissionid", item.GroupPermissionId),
                new Tuple<string, object>("name", item.Name)
            };

            db.ExecuteCommand("insert into  GroupPermissions values(" +
                                      "@grouppermissionid, @name)", parameters.ToArray());
        }

        public void Update(GroupPermission item)
        {
            var parameters = new List<Tuple<string, object>>
            {
                new Tuple<string, object>("grouppermissionid", item.GroupPermissionId),
                new Tuple<string, object>("name", item.Name)
            };

            db.ExecuteCommand("update GroupPermissions set " +
                                      "Name = @name where GroupPermissionId = @grouppermissionid", parameters.ToArray());
        }

        public void Delete(Guid id)
        {
            var parameters = new List<Tuple<string, object>>
            {
                new Tuple<string, object>("grouppermissionid", id)
            };

            db.ExecuteCommand("delete from GroupPermissions where GroupPermissionId = @grouppermissionid", parameters.ToArray());
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
