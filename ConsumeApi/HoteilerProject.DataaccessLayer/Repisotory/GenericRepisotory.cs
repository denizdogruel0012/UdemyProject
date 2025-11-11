using HoteilerProject.DataaccessLayer.Abstract;
using HoteilerProject.DataaccessLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoteilerProject.DataaccessLayer.Repisotory
{
    public class GenericRepisotory<T> : IGenericDal<T> where T : class
    {
        private readonly Context _context;

        public GenericRepisotory(Context context)
        {
            _context = context;
        }

        public void Add(T t)
        {
            _context.Add(t);
            _context.SaveChanges();
        }

        public void Delete(T t)
        {

            _context.Remove(t);
            _context.SaveChanges();

        }

        public T GetById(int id)
        {
            var values=_context.Set<T>().Find(id);
            return values;
        }

        public List<T> GetList()
        {
            return _context.Set<T>().ToList();
        }

        public void Update(T t)
        {
            _context.Update(t);
            _context.SaveChanges();
        }
    }
}
