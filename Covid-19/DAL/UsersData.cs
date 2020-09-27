using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Covid_19.DataModels;

namespace Covid_19.DAL
{
    class UsersData
    {
        public static string UserStats = "UserStats";
        public static List<string> Get()
        {
            List<string> userStats = new List<string>();
            string query = "SELECT [User] FROM [dbo].[User] ORDER BY [User] ASC;";
            var dataTable = MySQLAdapter.Get(query);
            foreach (DataRow row in dataTable.Rows)
            {
                userStats.Add(row["User"].ToString());
            }
            return userStats;
        }
    }
}
