using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
  public class MeetingController: Controller
  {
    [HttpGet]
    public IActionResult Apply()
    {
      return View();
    }
    [HttpPost]
    public IActionResult Apply(UserInfo model)
    {
      //Console.WriteLine($"{Name}\n{Email}\n{Phone}\n{WillAttend}");
      if(ModelState.IsValid){
        Repository.CreateUser(model);
        ViewBag.UserCount = Repository.Users.Where(i => i.WillAttend == true).Count();
        return View("Thanks",model);
      }else {
        return View(model);
      }
    }

    [HttpGet] //get metodu için yazmaya gerek yok çünkü default
    public IActionResult List()
    {
      return View(Repository.Users);
    }
    //meeting/details/idNum
    public IActionResult Details(int id)
    {
      return View(Repository.GetById(id));
    }
  }
}