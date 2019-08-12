using LostPeople.DataServices;
using System.Linq;
using System.Web.Mvc;

namespace LostPeople.Controllers
{
    public class HomeController : Controller
    {
        private readonly ServiceManager _serviceManager = new ServiceManager();
        

        public ActionResult Index()
        {
            
            return View();
        }


        
        public ActionResult Show(int count = 40)
        {
            var ShowLost = _serviceManager.Losts.GetLostPeople(count);
            return View("Show",ShowLost);
        }

        public ActionResult Search(string Id)
        {
            
            string SearchString = Id;
            var db = _serviceManager.Losts.Search();
            var person = from p in db
                         select p;

            if (!string.IsNullOrEmpty(SearchString))
            {
                person = person.Where(s => s.LAST_NAME.Contains(SearchString));
            }

            return View("Search",person);
        }

        public ActionResult Details(string Id)
        {
            var db = _serviceManager.Losts.Find(Id);
            var person = from p in db
                         select p;
            var photo = from p in db
                        select p;
                      
            return View("Details",person);
        }

        public ActionResult Map()
        {
            var db = _serviceManager.Losts.Search();

            var person = from p in db
                         select p;
            return View("Map",person);
        }
    }
}