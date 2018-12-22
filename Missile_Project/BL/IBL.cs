using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
namespace BL
{
    interface IBL 
    {
        void AddReport(Report report);
        void RemoveReport(int id);
        void UpdateReport(Report report);
        Report GetReportById(int id);

        void AddDrop(Drop drop);
        void RemoveDrop(int id);
        void UpdateDrop(Drop Drop);
        Drop GetDropById(int id);
    }
}
