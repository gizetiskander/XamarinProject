using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace XamarinProject.db
{
    public class Connection
    {
        SQLiteConnection db;
        public Connection(string databasePath)
        {
            db = new SQLiteConnection(databasePath);
            db.CreateTable<ProjectModel>();
        }
        public IEnumerable<ProjectModel> GetProjects()
        {
            return db.Table<ProjectModel>();
        }

        public ProjectModel GetProjectItem(int id)
        {
            return db.Get<ProjectModel>(id);
        }

        public int DelProj(int id) { return db.Delete<ProjectModel>(id); }

        public int SaveItem(ProjectModel projectModel)
        {
            if (projectModel.Id != 0)
            {
                db.Update(projectModel);
                return projectModel.Id;
            }
            else
            {
                return db.Insert(projectModel);
            }
        }

    }
}
