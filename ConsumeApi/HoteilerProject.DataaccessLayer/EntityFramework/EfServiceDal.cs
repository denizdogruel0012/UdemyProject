using HoteilerProject.DataaccessLayer.Abstract;
using HoteilerProject.DataaccessLayer.Concreate;
using HoteilerProject.DataaccessLayer.Repisotory;
using HoteilerProject.EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoteilerProject.DataaccessLayer.EntityFramework
{
    public class EfServiceDal : GenericRepisotory<Service>, IServiceDal
    {
        public EfServiceDal(Context context) : base(context)
        {
        }
    }
}
