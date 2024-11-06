using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
	public class Statistic: Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult Index()
		{
			ViewBag.v1 = context.Skills.Count();
			ViewBag.v2= context.ToDoLists.Count();
			ViewBag.v3 = context.Messages.Where(x => x.IsRead==false).Count();
			ViewBag.v4 = context.Messages.Where(x => x.IsRead==true).Count();
			return View();
		}
	}
}
