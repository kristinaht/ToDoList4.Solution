using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;
//___________________________________________________
//Body in response: The last line of code in a controller route indicates the resource that should be returned in the body of the response. In this case it is a View().
//___________________________________________________
namespace ToDoList.Controllers
{
  public class ItemsController : Controller
  {
    // [HttpGet("/items")]
    // public ActionResult Index()
    // {
    //  List<Item> allItems = Item.GetAll();
    //   return View(allItems);
    //   // Item starterItem = new Item("add first item to To Do List");
    //   // return View(starterItem);
    // }

      [HttpGet("/categories/{categoryId}/items/new")]
      public ActionResult New(int categoryId)
      {
        Category category = Category.Find(categoryId);
        return View(category);
      }

    [HttpPost("/items/delete")]
    public ActionResult DeleteAll()
    {
      Item.ClearAll();
      return View();
    }

    [HttpGet("/categories/{categoryId}/items/{itemId}")]
    public ActionResult Show(int categoryId, int itemId)
    {
      Item item = Item.Find(itemId);
      Category category = Category.Find(categoryId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("item", item);
      model.Add("category", category);
      return View(model);
    }
  }
}