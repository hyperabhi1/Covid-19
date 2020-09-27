using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid_19.DataModels
{
    class UserStats
    {
        public DateTime Time { get; set; }
        public string User { get; set; }
        public double Temperature { get; set; }
        public int Oximeter { get; set; }
        public int Heartrate { get; set; }
    }
}
