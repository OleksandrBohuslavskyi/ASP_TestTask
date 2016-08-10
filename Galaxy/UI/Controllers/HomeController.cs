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
            var context = new Core.Services.DataContextService();

            return View(context.GetAll().ToList());
        }

        public ActionResult Details(int id)
        {
            return View(new Core.Services.DataContextService().Read(id));
        }

        /// <summary>
        /// NEED TO CREATE better mechanism with check
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            new Core.Services.DataContextService().Delete(id);
        }

        public ActionResult Create()
        {
            ViewBag.TypesOfGlobe = Enum.GetNames(typeof(Core.DTOModels.GlobeTypeDto)).ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            new Core.Services.DataContextService().Create(new Core.DTOModels.GlobeDtoModel()
            {
                Description = collection["Description"],
                Discovered = Convert.ToDateTime(collection["Discovered"]),
                Distance = Convert.ToDouble(collection["Distance"]),
                Name = collection["Name"],
                TypeOfGlobe = (GlobeTypeDto)Enum.Parse(typeof(GlobeTypeDto),collection["typeOfGlobe"])
            });
            return RedirectToAction("ListOfGlobes");

        }


    }
}