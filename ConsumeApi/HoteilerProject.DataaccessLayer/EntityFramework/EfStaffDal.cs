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
    public class EfStaffDal : GenericRepisotory<Staff>, IStaffDal
    {
        public EfStaffDal(Context context) : base(context)
        {
        }
    }
}
