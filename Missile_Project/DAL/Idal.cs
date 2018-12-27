using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface Idal
    {

        void AddReport(Report Report);
        void RemoveReport(int id);
        void UpdateReport(Report Report);

        void AddDrop(Drop Drop);
        void RemoveDrop(int id);
        void UpdateDrop(Drop Drop);

        IEnumerable<BE.Report> getReportList(Func<Report, bool> predicate = null);
        IEnumerable<BE.Drop> getDropList(Func<Drop, bool> predicate = null);
        
        Drop GetDrop(int id);
        Report GetReport(int id);
        
    }
}
