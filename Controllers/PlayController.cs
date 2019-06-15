using Microsoft.AspNetCore.Mvc;
using Play.Models;
using Newtonsoft.Json;

namespace Play.Controllers
{
    public class PlayController : Controller
    {
        [HttpGet]
        public IActionResult Start()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Save(LetsPlay p)
        {
            return Json(JsonConvert.SerializeObject(p));
        }
    }
}