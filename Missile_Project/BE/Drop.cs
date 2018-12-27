using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Drop
    {
        public Drop(int drop_Id, string drop_Adress, DateTime drop_time, List<Report> reports, double real_lat, double real_log, double estimeated_lat, double estimeated_log)
        {
            Drop_Id = drop_Id;
            Drop_Adress = drop_Adress;
            Drop_time = drop_time;
            Reports = reports;
            Real_lat = real_lat;
            Real_log = real_log;
            Estimeated_lat = estimeated_lat;
            Estimeated_log = estimeated_log;
        }

        private int Drop_Id { get; set; }
        private string Drop_Adress { get; set; }
        private DateTime Drop_time { get; set; }
        private List<Report> Reports { get; set; }
        double Real_lat { get; set; }
        double Real_log { get; set; }
        double Estimeated_lat { get; set; }
        double Estimeated_log { get; set; }


        // private  string GPS_Coordinates { get; set; }
        //  private struct Lat_Long {public double Latitude;  public double Longitude;}  

    }
}
