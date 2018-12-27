using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    class Dal_imp : Idal
    {
        public void AddDrop(Drop Drop)
        {
            throw new NotImplementedException();
        }

        public void AddReport(Report Report)
        {
            throw new NotImplementedException();
        }

        public Drop GetDrop(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Drop> getDropList(Func<Drop, bool> predicate = null)
        {
            throw new NotImplementedException();
        }

        public Report GetReport(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Report> getReportList(Func<Report, bool> predicate = null)
        {
            throw new NotImplementedException();
        }

        public void RemoveDrop(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveReport(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateDrop(Drop Drop)
        {
            throw new NotImplementedException();
        }

        public void UpdateReport(Report Report)
        {
            throw new NotImplementedException();
        }
    }
}
