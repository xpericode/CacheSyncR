using System.Web.Mvc;

namespace WebApiDataAdmin.Controllers
{
    public class HomeController : Controller
    {
        private readonly XperiCode.CacheSyncR.IServer _server;

        public HomeController()
        {
            _server = new XperiCode.CacheSyncR.Server();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DataChanged()
        {
            _server.NotifyDataChanged("Customer", "FindAll", "Some group");
            return RedirectToAction("Index");
        }
    }
}