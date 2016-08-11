using System;
using System.Linq;
using System.Web.Mvc;
using Core.DTOModels;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListOfGlobes()
        {
            var context = new Core.Services.DataRepositoryService();
            return PartialView(context.GetAll().ToList());
        }

        public ActionResult Details(int id)
        {
            return View(new Core.Services.DataRepositoryService().Read(id));
        }

        /// <summary>
        /// NEED TO CREATE better mechanism with check for example ajax modal window
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            new Core.Services.DataRepositoryService().Delete(id);
        }

        public ActionResult Create()
        {
            ViewBag.TypesOfGlobe = Enum.GetNames(typeof(GlobeTypeDto)).ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Create(GlobeDtoModel model)
        {

            if (ModelState.IsValid)
            {
                new Core.Services.DataRepositoryService().Create(model);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.TypesOfGlobe = Enum.GetNames(typeof(GlobeTypeDto)).ToList();
                return View(model);

            }
        }

        public ActionResult Edit(int id)
        {
            ViewBag.TypesOfGlobe = Enum.GetNames(typeof(GlobeTypeDto)).ToList();
            return View(new Core.Services.DataRepositoryService().Read(id));
        }

        [HttpPost]
        public ActionResult Edit(GlobeDtoModel globe)
        {
            if (ModelState.IsValid)
            {
                new Core.Services.DataRepositoryService().Update(globe);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.TypesOfGlobe = Enum.GetNames(typeof(GlobeTypeDto)).ToList();
                return View(globe);

            }
        }
    }
}