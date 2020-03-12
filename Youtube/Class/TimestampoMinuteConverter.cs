using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtube.Class
{
    class TimestampoMinuteConverter
    {
        public double ConvertToMinutes(TimeSpan ts)
        {
            return ts.TotalMinutes;
        }   

    }
}
