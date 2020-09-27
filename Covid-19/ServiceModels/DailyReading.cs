using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid_19.ServiceModels
{
    class DailyReading
    {
        public float Temperature { get; set; }
        public int Oximeter { get; set; }
        public int Heartrate { get; set; }
    }
}
