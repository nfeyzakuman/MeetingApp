using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            //int saat = 13;
            int saat = DateTime.Now.Hour;
            //var selamlama = saat > 12 ? "İyi günler" : "Günaydın";
            ViewBag.Selamlama = saat > 12 ? "İyi günler" : "Günaydın";
            int UserCount = Repository.Users.Where(i => i.WillAttend == true).Count();
            //ViewBag.UserName = "Feyza";

            //ViewBag yerine ViewData kullanılabilir
            //ViewData["Selamlama"] = saat > 12 ? "İyi günler" : "Günaydın";
            //ViewData["UserName"] = "Feyza";

            var meetingInfo = new MeetingInfo(){
                Id = 1,
                Location = "İstanbul, Abc Kongre Merkezi",
                Date = new DateTime(2024, 01, 20, 20, 0, 0),
                NumberOfPeople = UserCount
            };

            return View(meetingInfo); //model: selamlama string bir bilgi için gerekli yoksa Viee ismi zannediyor
        }

    }
}