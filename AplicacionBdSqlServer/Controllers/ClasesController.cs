using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplicacionBdSqlServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AplicacionBdSqlServer.Controllers
{
    public class ClasesController : Controller
    {
        private readonly IClasesUpnContext _context;
        public ClasesController(IClasesUpnContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult MiAula()
        {
            ViewBag.Cursos = _context.Cursos.
                Include(o=>o.Alumnos).
                Include(x=>x.Profesores).ToList();
            return View();
        }
        [HttpGet]
        public IActionResult RegistrarA()
        {
            return View(new Alumno());
        }
        [HttpPost]
        public IActionResult RegistrarA(Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                _context.Alumnos.Add(alumno);
              //  _context.SaveChanges();
                return RedirectToAction("RegistrarM",alumno);
            }

            return View(new Alumno());
        }
        [HttpGet]
        public IActionResult RegistrarM(Alumno alumno)
        {
            ViewBag.IdAlumno = alumno.Id;
            ViewBag.Cursos = new List<string>{
                "Matematica","Comunicacion","Programacion"
            };
            ViewBag.Profesores = _context.Profesors.ToList();
            return View(new Curso());
        }
        [HttpPost]
        public IActionResult RegistrarM(Curso curso)
        {
            curso.Nota = 0;
            curso.Credito = 4;
            if (ModelState.IsValid)
            {
                _context.Cursos.Add(curso);
               // _context.SaveChanges();
                return RedirectToAction("MiAula");
            }

            return View(new Curso());
        }
       

        //logued
        //protected User LoggedUser()
        //{
        //    var claim = HttpContext.User.Claims.FirstOrDefault();
        //    var user = _context.Users.Where(o => o.Username == claim.Value).FirstOrDefault();
        //    return user;
        //}
    }
}
