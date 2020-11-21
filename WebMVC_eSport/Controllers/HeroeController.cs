using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebMVC_eSport.ProxyHeroe;

namespace WebMVC_eSport.Controllers
{
    public class HeroeController : Controller
    {
        ServicioHeroeClient miservHeroes = new ServicioHeroeClient();
        // GET: Heroes
        public ActionResult Index()
        {
            ViewBag.ListarHeroes = miservHeroes.ListarHerores();
            return View();
        }

        public ActionResult Update(HeroeBE objHeroe)
        {
            if (objHeroe == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            if (miservHeroes.HeroeUpdate(objHeroe) == true){

                return View(objHeroe);
            }
            else
            {
                return HttpNotFound();
            }
            
        }

        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            if (miservHeroes.HeroeDelete(id) == true)
            {
                return View(id);
            }
            else
            {
                return HttpNotFound();
            }

        }
    }
}