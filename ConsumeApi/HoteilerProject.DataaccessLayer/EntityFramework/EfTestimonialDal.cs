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
    public class EfTestimonialDal : GenericRepisotory<Testimonial>, ITestimonialDal
    {
        public EfTestimonialDal(Context context) : base(context)
        {
        }
    }
}
