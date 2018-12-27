using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Report
    {
        public Report(int id, DateTime time, string name, string report_Adress, int boom_count, string imagePath, double lat, double log)
        {
            this.id = id;
            Time = time;
            Name = name;
            Report_Adress = report_Adress;
            Boom_count = boom_count;
            ImagePath = imagePath;
            this.lat = lat;
            this.log = log;
        }

        int id { get; set; }
        DateTime Time { get; set; }
        string Name { get; set; }
        string Report_Adress { get; set; }
        int Boom_count { get; set; }
        string ImagePath { get; set; }
        double lat { get; set; }
        double log { get; set; }


    }
}
