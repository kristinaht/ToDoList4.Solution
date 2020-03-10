using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
//___________________________________________________
//Body in response: The last line of code in a controller route indicates the resource that should be returned in the body of the response. In this case it is a View().
//___________________________________________________
namespace ToDoList.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      Item starterItem = new Item("add first item to To Do List");
      return View(starterItem);
    }

    [HttpGet("/items/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

//[Route("/items)] Create() is only for creating new items. No need to create Create.cshtml 
  [HttpPost("/items")]
    public ActionResult Create(string description)
    {
      Item myItem = new Item(description);
      return View("Index", myItem);
      //"Index" specifies the view that should be returned because we are no longer routing to a view with the same exact name as our route method.
    }
  }
}