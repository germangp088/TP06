using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MateriaController : Controller
    {
        static List<MateriaModels> materias = new List<MateriaModels>();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Agregar(int legajo)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Agregar()
        {
            try
            {
                // TODO: Add insert logic here
                MateriaModels materia = new MateriaModels();
                materia.Legajo = int.Parse(Request.Form["legajo"].ToString());
                materia.Nombre_Materia = Request.Form["Nombre_Materia"];
                materia.Fecha_Materia = DateTime.Parse(Request.Form["Fecha_Materia"].ToString());
                materia.Nota_Materia = int.Parse(Request.Form["Nota_Materia"].ToString());
                materias.Add(materia);
                return View("Index", materias);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Detail(string nombre) {
            return View(materias.Find(x => x.Nombre_Materia == nombre));
        }

        public ActionResult Materias(int legajo)
        {
            return View(materias.FindAll(x => x.Legajo == legajo));
        }
    }
}