using AutoMapper;
using IAE.Escola.Dominio;
using IAE.Escola.Repositorio.Entity;
using IAE.Repository.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace IAE.Escola.Web.Controllers
{
    public class TurmasController : Controller
    {
        private IRepositorioGenerico<Turma, int> _repositorio 
            = new RepositorioTurma();

        // GET: Turmas
        public ActionResult Index()
        {
            List<TurmaViewModel> viewModels =
               Mapper.Map<List<Turma>, List<TurmaViewModel>>(_repositorio.Selecionar());
             
            return View(viewModels);

        }

        // GET: Turmas/Details/5
        public ActionResult Details(int? id)
        {
            if( id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Turma turma = _repositorio.SelecionarPelaChave(id.Value);
            TurmaViewModel viewModel = Mapper.Map<Turma, TurmaViewModel>(turma);
            return View(viewModel);
        }

        // GET: Turmas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Turmas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Exclude = "IsAtivo")]TurmaViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                Turma novaTurma = Mapper.Map<TurmaViewModel, Turma>(viewModel);
                novaTurma.IsAtivo = true;
                _repositorio.Inserir(novaTurma);
                return RedirectToAction("index");
            }
            else
            {
                return View(viewModel);
            }
        }

        // GET: Turmas/Edit/5
        public ActionResult Edit(int id)
        {
            Turma turma = _repositorio.SelecionarPelaChave(id);
            TurmaViewModel viewModel 
                = Mapper.Map<Turma, TurmaViewModel>(turma);

            return View(viewModel);
        }

        // POST: Turmas/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, [Bind(Include ="Id,Nome,IsAtivo")]TurmaViewModel viewModel)
        {
            if (ModelState.IsValid)
            {

                Turma turma =  Mapper.Map<TurmaViewModel, Turma>(viewModel);

                _repositorio.Atualizar(turma);

                return RedirectToAction("index");

            }
            else
            {
                return View(viewModel);

            }
                
            
        }

        // GET: Turmas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Turmas/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Turma turma = _repositorio.SelecionarPelaChave(id);
            _repositorio.Atualizar(turma);
            return RedirectToAction("Index");
        }
    }
}
