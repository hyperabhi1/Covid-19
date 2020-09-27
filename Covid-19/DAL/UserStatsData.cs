using Covid_19.DataModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid_19.DAL
{
    class UserStatsData
    {
        public static string UserStats = "UserStats";
        public static List<UserStats> Get()
        {
            List<UserStats> userStats = new List<UserStats>();
            string query = "SELECT [Time], [User], [Temperature], [Oximeter], [Heartrate] FROM [dbo].[UserStats] ORDER BY [User], [Time] Desc;";
            var dataTable = MySQLAdapter.Get(query);
            foreach (DataRow row in dataTable.Rows)
            {
                userStats.Add(new UserStats()
                {
                    Time = DateTime.Parse(row["Time"].ToString()),
                    User = row["User"].ToString(),
                    Temperature = float.Parse(row["Temperature"].ToString()),
                    Oximeter = int.Parse(row["Oximeter"].ToString()),
                    Heartrate = int.Parse(row["Heartrate"].ToString())
                });
            }
            return userStats;
        }
        public static bool Insert(UserStats userStats)
        {
            string query = $"INSERT INTO UserStats VALUES ('{userStats.Time}','{userStats.User}', '{userStats.Temperature}', '{userStats.Oximeter}', '{userStats.Heartrate}');";
            MySQLAdapter.Insert(query);
            return true;
        }
    }
}
