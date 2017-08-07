using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoogleGoogle.Logic
{
    public class EorzeaTime
    {
        public const double eorzea_Constant = 20.571428571428573;
        
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public override string ToString()
        {
            return String.Format(
                "{0:00}:{1:00}:{2:00}",
                this.Hours, this.Minutes, this.Seconds);
        }

        public static DateTime Now
        {
            get
            {
                UnixTime actual_Time = UnixTime.FromDateTime(DateTime.UtcNow);
                double eorzea_Unix = actual_Time.Timestamp * eorzea_Constant;

                DateTime eorzea_Current_Time = UnixTime.ToUniversalDateTime(eorzea_Unix);

                return eorzea_Current_Time;

            }
            set { }
        }
    }

    
}
