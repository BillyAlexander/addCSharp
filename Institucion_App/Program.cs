using Institucion_App.DataAccess;
using Institucion_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institucion_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("gestion de institucion");
            var db = new clsInstitucionDB();
            clsProfesor profesor1 = new clsProfesor();
            profesor1.nombre = "Alex";
            profesor1.apellido = "Villa";

            db.profesores.Add(profesor1);
            db.SaveChanges();
            Console.ReadLine();
        }
    }
}
