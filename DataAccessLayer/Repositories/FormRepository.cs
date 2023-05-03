using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class FormRepository : IFormDal
    {
        
        public void AddForm(Form form)
        {
            using var context = new Context();
            context.Add(form);
            context.SaveChanges();
        }

        public Form GetById(int id)
        {
            using var context = new Context();
            return context.Forms.Find(id);
        }

        public List<Form> GetListAll()
        {
            using var context = new Context();
            return context.Forms.ToList();
        }

        public void Insert(Form item)
        {
            using var context = new Context();
            context.Add(item);
            context.SaveChanges();
        }

        public List<Form> ListAllForm()
        {
            using var context = new Context();
            return context.Forms.ToList();
        }
    }
}
