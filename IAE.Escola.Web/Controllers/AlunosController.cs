using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IAE.Escola.Dominio;
using IAE.Repository.Common;
using IAE.Escola.Repositorio.Entity;
using AutoMapper;
using IAE.Escola.Web.Models;

namespace IAE.Escola.Web.Controllers
{
    public class AlunosController : Controller
    {
        private IRepositorioGenerico<Aluno, long> _repositorio ;

        public AlunosController(IRepositorioGenerico<Aluno, long> repositorio
            )
        {
            _repositorio = repositorio;
        }


        // GET: Alunos
        public ActionResult Index()
        {
            return View(Mapper.Map<List<Aluno>, List<AlunoViewModel>>(_repositorio.Selecionar()));
        }

        // GET: Alunos/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aluno aluno = _repositorio.SelecionarPelaChave(id.Value);
            if (aluno == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Aluno, AlunoViewModel>(aluno));
        }

        // GET: Alunos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alunos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create([Bind(Include = "Id,Nome,Telefone,Matricula,Email,DataNascimento")] AlunoViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Aluno aluno = Mapper.Map<AlunoViewModel, Aluno>(viewModel);
                _repositorio.Inserir(aluno);
                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        // GET: Alunos/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aluno aluno = _repositorio.SelecionarPelaChave(id.Value);
            if (aluno == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Aluno, AlunoViewModel>(aluno));
        }

        // POST: Alunos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Telefone,Matricula,Email,DataNascimento")] AlunoViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Aluno aluno = Mapper.Map<AlunoViewModel, Aluno>(viewModel);
                _repositorio.Atualizar(aluno);
                return RedirectToAction("Index");
            }
            return View(viewModel);
        }

        // GET: Alunos/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aluno aluno = _repositorio.SelecionarPelaChave(id.Value);
            if (aluno == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Aluno, AlunoViewModel>(aluno));
        }

        // POST: Alunos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Aluno aluno = _repositorio.SelecionarPelaChave(id);
            _repositorio.Deletar(aluno);
            return RedirectToAction("Index");
        }

   
    }
}
