using Microsoft.AspNetCore.Mvc;
namespace dojo_survey.Controllers     //be sure to use your own project's namespace!copy
{
    public class HomeController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("method")]
        public IActionResult Method(string name, string locationList, string languageList, string comment)
        {
            ViewBag.Name = name;
            ViewBag.LocationList = locationList;
            ViewBag.LanguageList = languageList;
            ViewBag.Comment = comment;

            return View("Result");
        }
    }
}