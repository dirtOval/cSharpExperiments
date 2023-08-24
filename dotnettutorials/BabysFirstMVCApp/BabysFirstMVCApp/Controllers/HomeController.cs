using Microsoft.AspNetCore.Mvc;
namespace BabysFirstMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "This is index action from MVC Controller";
        }
    }
}
