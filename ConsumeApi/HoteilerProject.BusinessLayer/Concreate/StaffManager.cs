using HoteilerProject.BusinessLayer.Abstract;
using HoteilerProject.DataaccessLayer.Abstract;
using HoteilerProject.EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoteilerProject.BusinessLayer.Concreate
{
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staffdal;

        public StaffManager(IStaffDal staffdal)
        {
            _staffdal = staffdal;
        }

        public void TAdd(Staff t)
        {
            _staffdal.Add(t);
        }

        public void TDelete(Staff t)
        {
            _staffdal.Delete(t);
        }

        public Staff TGetById(int id)
        {
            return _staffdal.GetById(id);
        }

        public List<Staff> TGetList()
        {
            return _staffdal.GetList();
        }

        public void TUpdate(Staff t)
        {
           _staffdal.Update(t);
        }
    }
}
