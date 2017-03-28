using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


using EscuelaMVC.ViewModel;
using EscuelaMVC.Comun;
using EscuelaMVC.Models;


namespace EscuelaMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Alumno> Datos = AlumnoViewModel.listaContenido();
            ViewBag.Datos = Datos;

            return View();
        }
        public ActionResult VerDetalle(int Id)
        {

            Alumno Datos = AlumnoViewModel.ObtenerDatos(Id);
            ViewBag.Datos = Datos;
            return View();
        }
        public ActionResult getImagen(int Id)
        {
            Alumno temAlumno = AlumnoViewModel.ObtenerDatos(Id);
            var temImage = ToolImage.Base64StringToBitmap(temAlumno.sImagen);
            var temMapBytes = ToolImage.BitmapToBytes(temImage);

            return File(temMapBytes,"image/jpg");


        }
        public ActionResult frmActualizar(int Id)
        {
            Alumno datos = AlumnoViewModel.ObtenerDatos(Id);
            ViewBag.Datos = datos;
            return View();
               
        }
       
    }
    
    
}