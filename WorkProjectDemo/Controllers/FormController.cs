using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace WorkProjectDemo.Controllers
{
    public class FormController : Controller
    {
        FormManager formManager = new FormManager(new EFFormRepository());
        public IActionResult Index()
        {
            var values=formManager.GetListForms();
            return View(values);
        }
    }
}
