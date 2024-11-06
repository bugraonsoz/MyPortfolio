using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class LayoutController : Controller
    {
		public class AdminViewModel
		{
			public List<ToDoList> ToDoLists { get; set; }
			public List<Message> Messages { get; set; }
		}
		public IActionResult Index()
        {
            return View();
        }
    }
}
