using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace WorkProject.Controllers
{
    public class FormController : Controller
    {
        FormManager formManager = new FormManager(new EFFormRepository());
        public IActionResult Index()
        {
            var values = formManager.GetListForms();
            return View(values);
        }
        public IActionResult PartialView(int id)
        {
            var model =formManager.GetById(id);
            return PartialView("_MyPartialView", model);
        }

    }
}
