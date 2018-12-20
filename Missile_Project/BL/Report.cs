using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
  public class Report
    {

        DateTime Time { get; set; }
        string Name   { get; set; }
        string Adress { get; set; }
        int Boom_count { get; set; }
        
        //ctor
        public Report(DateTime time, string name, string adress, int boom_count)
        {
            Time = time;
            Name = name;
            Adress = adress;
            Boom_count = boom_count;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
