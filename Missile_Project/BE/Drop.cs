using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Drop
    {
        public Drop(string drop_Adress, DateTime drop_time, string gPS_Coordinates, List<Report> reports)
        {
            Drop_Adress = drop_Adress;
            Drop_time = drop_time;
            GPS_Coordinates = gPS_Coordinates;
            Reports = reports;
        }

        private string Drop_Adress { get; set; }
        private DateTime Drop_time { get; set; }
        // private  string Drop_name { get; set; }
        private struct Lat_Long {public double Latitude;  public double Longitude;}  
       private  string GPS_Coordinates { get; set; }
       private List <Report> Reports { get; set; }

    }
}
