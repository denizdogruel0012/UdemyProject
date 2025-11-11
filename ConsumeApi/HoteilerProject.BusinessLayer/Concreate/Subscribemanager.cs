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
    public class Subscribemanager : ISubscribeService
    {
        private readonly ISubscribeDal _subscribedal;

        public Subscribemanager(ISubscribeDal subscribedal)
        {
            _subscribedal = subscribedal;
        }

        public void TAdd(Subscribe t)
        {
            _subscribedal.Add(t);
        }

        public void TDelete(Subscribe t)
        {
           _subscribedal.Delete(t);
        }

        public Subscribe TGetById(int id)
        {
            return _subscribedal.GetById(id);
        }

        public List<Subscribe> TGetList()
        {
            return _subscribedal.GetList();
        }

        public void TUpdate(Subscribe t)
        {
            _subscribedal.Update(t);
        }
    }
}
