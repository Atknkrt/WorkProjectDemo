using BusinessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;

namespace BusinessLayer.Concrete
{
    public class FormManager : IFormService
    {
        IFormDal _formDal;
        public FormManager(IFormDal formDal)
        {
            _formDal = formDal;
        }
        public void FormAdd(Form form)
        {
            _formDal.Insert(form);
        }

        public Form GetById(int id)
        {
          return _formDal.GetById(id);
        }

        public List<Form> GetListForms()
        {
           return _formDal.GetListAll();
        }
    }
}
