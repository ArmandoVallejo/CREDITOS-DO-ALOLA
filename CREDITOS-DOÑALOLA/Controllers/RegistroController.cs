using CREDITOS_DOÑALOLA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CREDITOS_DOÑALOLA.Controllers
{
    public class RegistroController : Controller
    {
        // GET: Registro
        public ActionResult Index()
        {
            PersonasDBEntities db = new PersonasDBEntities();
            List<Persona> lista = db.Persona.ToList();

            
            for(int i = 0; i < lista.Count() ; i++)
            {
                float inter = lista[i].Intereses;
                inter/=100;
              
                float totalInteres = (((float)lista[i].CantidadPrestada) * inter) * lista[i].MesesPrestamo;
                lista[i].MontoFinal = (float)lista[i].CantidadPrestada + totalInteres;
                 
             
            }

            return View(lista);
        }

        public ActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Agregar(Persona obj)
        {
            if (!ModelState.IsValid)
            
                return View();

            try
            {
                using (var db = new PersonasDBEntities())
                {
                    obj.FechaPrestamo = DateTime.Now;
                    db.Persona.Add(obj);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al agregar el deudor", ex.Message);
                return View();
            }
            
        }

        public ActionResult InfoPagos()
        {
            int idp = 0;

            PersonasDBEntities db = new PersonasDBEntities();
            List<Persona> lista = db.Persona.ToList();

            var result = lista.Where(x => x.Id == idp);

            InfoPagos dbinfo = new InfoPagos();
            List<InfoPagos> Listpagos = dbinfo

            return View();
        }
    }
}