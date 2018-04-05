using EFTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace EFTest.Controllers
{
    public class HomeController : Controller
    {
        private EFDbContext _dbContext = null;

        public HomeController()
        {
            _dbContext = new EFDbContext();
        }

        public ActionResult Index()
        {
            ListaAlumnos lst = new ListaAlumnos();
            lst.Alumnos = _dbContext.Alumnos.OrderBy(x => x.Nombres).ToList();
            return View(lst);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public void InsertarData(string nombre, string apellido, string id)
        {
            ListaAlumnos lst = new ListaAlumnos();
            if (!String.IsNullOrEmpty(nombre) && !String.IsNullOrEmpty(apellido))
            {
                Alumno objAlumno = new Alumno
                {
                    Apellidos = apellido,
                    Nombres = nombre
                };

                if (String.IsNullOrEmpty(id))
                {
                    _dbContext.Alumnos.Add(objAlumno);
                    _dbContext.SaveChanges();
                }
                else
                {
                    bool result = Int32.TryParse(id, out int ident);
                    if (result)
                    {
                        objAlumno = _dbContext.Alumnos.SingleOrDefault(x => x.Id == ident);
                        objAlumno.Nombres = nombre;
                        objAlumno.Apellidos = apellido;
                        _dbContext.SaveChanges();
                    }
                }

            }

        }

        [HttpGet]
        public String GetDatos(string id)
        {
            Alumno objAlumno = new Alumno();
            var json = "";
            if (!String.IsNullOrEmpty(id))
            {
                bool result = Int32.TryParse(id, out int noSalida);

                if (result)
                {
                    objAlumno = _dbContext.Alumnos.SingleOrDefault(x => x.Id == noSalida);
                    json = new JavaScriptSerializer().Serialize(objAlumno);

                }

            }
            return json;

        }
    }
}