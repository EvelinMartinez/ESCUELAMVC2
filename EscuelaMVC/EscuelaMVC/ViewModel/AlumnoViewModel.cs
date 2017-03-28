using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EscuelaMVC.Models;
using System.Data.Entity;

namespace EscuelaMVC.ViewModel
{
    public class AlumnoViewModel
    {
        public static List<Alumno>listaContenido()
        {
            try
            {
                var ctx = new DataModel();
                return ctx.Alumno.Where(r => r.bStatus == true).ToList();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static Alumno ObtenerDatos( int Id)
        {
            try
            {
                var ctx = new DataModel();
                return ctx.Alumno.Where(r => r.bStatus == true && r.pkAlumno==Id).FirstOrDefault();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}