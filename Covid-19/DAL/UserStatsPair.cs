using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid_19.DAL
{
    class UserStatsPair
    {
        public List<KeyValuePair<DateTime, double>> TemperatureCollection { get; set; }
        public List<KeyValuePair<DateTime, int>> OximeterCollection { get; set; }
        public List<KeyValuePair<DateTime, int>> HeartrateCollection { get; set; }
    }
}
