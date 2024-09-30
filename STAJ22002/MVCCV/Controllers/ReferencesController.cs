using MVCCV.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCV.Models.Entity;

namespace MVCCV.Controllers
{
    
    public class ReferencesController : Controller
    {
        ReferencesRepository repo = new ReferencesRepository();
        // GET: Experience
        public ActionResult Index()
        {
            var values = repo.List();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddReference()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddReference(TblReferences exp)
        {
            repo.TAdd(exp);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteReference(int id)
        {
            TblReferences t = repo.Find(x => x.Id == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult GetReference(int id)
        {
            TblReferences t = repo.Find(x => x.Id == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult GetReference(TblReferences p)
        {
            TblReferences t = repo.Find(x => x.Id == p.Id);
            t.NameSurname = p.NameSurname;
            t.Title = p.Title;
            t.Phone = p.Phone;
            
            repo.TUpdate(t);

            return RedirectToAction("Index");
        }
    }
}