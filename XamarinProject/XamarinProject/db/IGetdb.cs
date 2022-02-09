using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinProject.db
{
    public interface IGetdb
    {
        string GetDatabasePath(string filename);
    }
}
