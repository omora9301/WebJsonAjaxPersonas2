using AppBussPersona;
using EntityPersonas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebJsonAjaxPersonas.Controllers
{
    public class HomeController : Controller
    {
        BPersona bp = new BPersona();
        EntPersonas ep = new EntPersonas();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult Obtener()
        {
            try
            {
                List<EntPersonas> listaO = bp.Obtener();
                return Json(new {mensaje = "Ok", ls = listaO }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { mensaje = ex.Message});
            }
        }

    }
}