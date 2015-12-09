using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using IAE.Escola.Dominio;
using IAE.Repository.Common;
using IAE.Escola.Repositorio.Entity;
using AutoMapper;
using System.Collections.Generic;
using IAE.Escola.Web.Models;

namespace IAE.Escola.Web.Controllers
{
    public class CursosController : Controller
    {
        private IRepositorioGenerico<Curso, long> _repositorio = new RepositorioCurso();

        // GET: Cursos
        public ActionResult Index()
        {
            return View(Mapper.Map<List<CursoViewModel>>
                (_repositorio.Selecionar()));
        }

        // GET: Cursos/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Curso curso = _repositorio.SelecionarPelaChave(id.Value);
            if (curso == null)
            {
                return HttpNotFound();
            }
            return View(curso);
        }

        // GET: Cursos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cursos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Ementa,CargaHoraria,isAtivo")] CursoViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Curso curso = Mapper.Map<CursoViewModel, Curso>(viewModel);
                _repositorio.Inserir(curso);
                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        // GET: Cursos/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Curso curso = _repositorio.SelecionarPelaChave(id.Value);
            if (curso == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Curso, CursoViewModel>(curso));
        }

        // POST: Cursos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Ementa,CargaHoraria,isAtivo")] CursoViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Curso curso = Mapper.Map<CursoViewModel, Curso>(viewModel);

                _repositorio.Atualizar(curso);
                return RedirectToAction("Index");
            }
            return View(viewModel);
        }

        // GET: Cursos/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Curso curso = _repositorio.SelecionarPelaChave(id.Value);
            if (curso == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Curso, CursoViewModel>(curso));
        }

        // POST: Cursos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Curso curso = _repositorio.SelecionarPelaChave(id);
            _repositorio.Deletar(curso);
            return RedirectToAction("Index");
        }

       
    }
}
