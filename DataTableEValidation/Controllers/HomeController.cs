using DataTableEValidation.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataTableEValidation.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult _TabelaAlunos()
        {
            var business = new AlunoBusiness();
            var listaAlunos = business.CarregarTodos();
            return Json(listaAlunos ?? (object)false, JsonRequestBehavior.AllowGet);
        }
    }
}
