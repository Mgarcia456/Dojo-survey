using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Survey.Models;



using Microsoft.AspNetCore.Mvc;

namespace Survey.Controllers

{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("index");
        }

        [HttpPost("result")]
        public IActionResult Result(string Name, string Location, string Language, string Comment)
        {
            ViewBag.Name = Name;
            ViewBag.Location = Location;
            ViewBag.Language = Language;
            ViewBag.Comment = Comment;
            return View("result");
        }
    }
}