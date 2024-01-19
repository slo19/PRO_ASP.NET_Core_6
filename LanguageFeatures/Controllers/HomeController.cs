using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers {
    public class HomeController : Controller {

        public ViewResult Index() {
            return view(new string[] {"C#", "Language", "Features"});
        }
    }
}