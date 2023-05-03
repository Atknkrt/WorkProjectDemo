using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IFormService
    {
        void FormAdd(Form form);
        List<Form> GetListForms();
        Form GetById(int id);
    }
}
