using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using WebEvents.DbLayer;
using WebEvents.Models;

namespace WebEvents.Controllers
{
    public class EventsController : Controller
    {
        private EventsContext db = new EventsContext();

        // GET: Events
        public ActionResult Index()
        {
            var ev = from e in db.Events orderby e.StartDate select e;
            return View(ev);
        }

        // GET: Events/Details/5
        public ActionResult Details(int? id)
        {
            if (id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event e=db.Events.Find(id);
            if (e == null)
            {
                return HttpNotFound();
            }
            return View(e);
        }

        // GET: Events/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Events/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Location,StartDate,EndDate")] Event eve)
        {
            ModelState.Clear();

            if (ModelState.IsValid)
            {
                db.Events.Add(eve);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eve);
        }

        // GET: Events/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event e = db.Events.Find(id);
            if (e == null)
            {
                return HttpNotFound();
            }
            return View(e);
        }

        // POST: Events/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id,Name,Location,StartDate,EndDate")] Event e)
        {
            if (ModelState.IsValid)
            {
                db.Entry(e).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(e);
        }

        // GET: Events/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event e = db.Events.Find(id);
            if (e == null)
            {
                return HttpNotFound();
            }
            return View(e);
        }

        // POST: Events/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            Event e = db.Events.Find(id);
            db.Events.Remove(e);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
