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

        public static DateTime ConvertFromDBTime(double DBTime)
        {
            // 0.25 - 0.329861111111111       ->           06:00 - 07:55
            double hours = 0;
            double minutes = 0;
            double mod = (DBTime * 24) % 1;

            hours = (DBTime * 24) - mod;
            minutes = Math.Ceiling(mod * 60);

            return new DateTime(1, 1, 1).AddHours(hours).AddMinutes(minutes);

        }

        public static double ConvertToDBTime(DateTime dt)
        {
            // 06:00 - 07:55        ->           0.25 - 0.329861111111111
            double totalMinsInDay = 24 * 60;
            double mins = (dt.Hour * 60) + dt.Minute;
            
            return (mins / totalMinsInDay) + (mins % totalMinsInDay);
        }
    }

    
}
