using AppWeb.ClassContext;
using AppWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWeb.Controllers
{
    public class AppWebController : Controller
    {
        private readonly AppWebContext contexto;

        public AppWebController(AppWebContext contexto)
        {
            this.contexto = contexto;
        }

        public IActionResult Alunos()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Alunos(AlunoModel aluno)
        {

            if (ModelState.IsValid)
            {
                contexto.Aluno.Add(aluno);
                contexto.SaveChanges();
                return RedirectToAction("Provas",aluno);


            }
            return View();



        }

        public IActionResult Provas()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Provas(Prova prova,AlunoModel aluno)
        {
            Prova provas = new Prova();

            provas.Materia = prova.Materia;
            provas.Nota = prova.Nota;
            provas.AlunoId = aluno.AlunoId;

            contexto.Add(provas);
            contexto.SaveChanges();

            return View();
           
        }
    }
}
