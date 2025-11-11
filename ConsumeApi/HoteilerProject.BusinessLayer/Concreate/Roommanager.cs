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
    public class Roommanager : IRoomservice
    {
        private readonly IRoomDal _roomdal;

        public Roommanager(IRoomDal roomdal)
        {
            _roomdal = roomdal;
        }

        public void TAdd(Room t)
        {
            _roomdal.Add(t);
        }

        public void TDelete(Room t)
        {
            _roomdal.Delete(t);
        }

        public Room TGetById(int id)
        {
          var values= _roomdal.GetById(id);
            return values;
        }

        public List<Room> TGetList()
        {
            var values = _roomdal.GetList();
            return values;
        }

        public void TUpdate(Room t)
        {
            throw new NotImplementedException();
        }
    }
}
