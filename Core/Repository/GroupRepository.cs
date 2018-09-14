using Core.DB;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;

namespace Core.Repository
{
    public class GroupRepository : IRepository<Entities.Group>
    {
        #region Fields&Properties

        private DBManager db;

        #endregion

        #region Constructors

        public GroupRepository()
        {
            db = DBManager.GetInstance();
        }

        #endregion

        #region RepositoryItems

        public IEnumerable<Entities.Group> GetList()
        {
            var ds = db.ExecuteReader("select * from Groups");

            var groups = new List<Entities.Group>();

            foreach (DataRow row in (ds.Tables[0].Rows))
            {
                var group = new Entities.Group();

                group.GroupId = (Guid)row[0];
                group.Name = row[1].ToString();
                group.CreateDate = (DateTime)row[2];
                group.GroupCreator = (Guid)row[3];

                groups.Add(group);
            }

            return groups;
        }

        public Entities.Group Get(System.Guid id)
        {
            var parameters = new List<Tuple<string, object>>
            {
                new Tuple<string, object>("groupid", id)
            };

            var ds = db.ExecuteReader("select * from Groups where GroupId = @groupid", parameters.ToArray());

            var group = new Entities.Group();

            var row = ds.Tables[0].Rows[0];

            group.GroupId = (Guid)row[0];
            group.Name = row[1].ToString();
            group.CreateDate = (DateTime)row[2];
            group.GroupCreator = (Guid)row[3];

            return group;
        }

        public IEnumerable<User> GetUsers(System.Guid groupid)
        {
            using (IRepository<User> UserRepository = new UserRepository())
            {
                return UserRepository.GetList().Where(u => (bool)(u.Group != null && u.Group.GroupId == groupid));
            }
        }

        public void Create(Entities.Group item)
        {
            var parameters = new List<Tuple<string, object>>
            {
                new Tuple<string, object>("groupid", item.GroupId),
                new Tuple<string, object>("name", item.Name),
                new Tuple<string, object>("createdate", item.CreateDate),
                new Tuple<string, object>("groupcreatorid", item.GroupCreator)
            };

            db.ExecuteCommand("insert into Groups values(" +
                "@groupid, @name, @createdate, @groupcreatorid)", parameters.ToArray());
        }

        public void Update(Entities.Group item)
        {
            var parameters = new List<Tuple<string, object>>
            {
                new Tuple<string, object>("groupid", item.GroupId),
                new Tuple<string, object>("name", item.Name),
                new Tuple<string, object>("createdate", item.CreateDate),
                new Tuple<string, object>("groupcreatorid", item.GroupCreator)
            };

            db.ExecuteCommand("update Groups set " +
                "Name = @name, CreateDate = @createdate, GroupCreatorId = @groupcreatorid " +
                "where GroupId = @groupid", parameters.ToArray());
        }

        public void Delete(Guid id)
        {
            var parameters = new List<Tuple<string, object>>
            {
                new Tuple<string, object>("groupid", id)
            };

            db.ExecuteCommand("delete from Groups where GroupId = @groupid", parameters.ToArray());
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
