using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Titanio.Models;

namespace Titanio.Controllers
{ 
    public class ProjetoController : Controller
    {
        private TitanioDBContext db = new TitanioDBContext();

        //
        // GET: /Projeto/

        public ViewResult Index()
        {
            return View(db.Projetos.ToList());
        }

        //
        // GET: /Projeto/Details/5

        public ViewResult Details(int id)
        {
            Projeto projeto = db.Projetos.Find(id);
            return View(projeto);
        }

        //
        // GET: /Projeto/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Projeto/Create

        [HttpPost]
        public ActionResult Create(Projeto projeto)
        {
            if (ModelState.IsValid)
            {
                db.Projetos.Add(projeto);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(projeto);
        }
        
        //
        // GET: /Projeto/Edit/5
 
        public ActionResult Edit(int id)
        {
            Projeto projeto = db.Projetos.Find(id);
            return View(projeto);
        }

        //
        // POST: /Projeto/Edit/5

        [HttpPost]
        public ActionResult Edit(Projeto projeto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(projeto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(projeto);
        }

        //
        // GET: /Projeto/Delete/5
 
        public ActionResult Delete(int id)
        {
            Projeto projeto = db.Projetos.Find(id);
            return View(projeto);
        }

        //
        // POST: /Projeto/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Projeto projeto = db.Projetos.Find(id);
            db.Projetos.Remove(projeto);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}