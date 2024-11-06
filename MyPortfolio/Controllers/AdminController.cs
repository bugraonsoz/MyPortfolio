using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;
using NuGet.Common;

namespace MyPortfolio.Controllers
{
    public class AdminController : Controller
    {   
        SqlConnection con=new SqlConnection();
        SqlCommand com= new SqlCommand();
        SqlDataReader dr;
        [HttpGet]
       

        public IActionResult Index()
        {
            return View();
        }
        
        
        void connectionString()
        {
            con.ConnectionString = "data source=DESKTOP-TC3KKGK; database=MyPortfolioDb; integrated security=SSPI;";
		}
		[HttpPost]
		public ActionResult Verify(Admin admin)
		{
			connectionString();
			con.Open();
			com.Connection = con;
			com.CommandText = "select * from Admins where Email = @Email and Password = @Password";

			// Parametre ekleyerek SQL Injection önleniyor
			com.Parameters.AddWithValue("@Email", admin.Email);
			com.Parameters.AddWithValue("@Password", admin.Password);

			dr = com.ExecuteReader();

			if (dr.Read())
			{
				con.Close();
				// Admin paneline yönlendirme
				return RedirectToAction("Dashboard", "AdminPanel");
			}
			else
			{
				con.Close();
				// Hatalı giriş durumunda tekrar giriş sayfasına yönlendirme
				ViewBag.ErrorMessage = "Geçersiz e-posta veya şifre.";
				return View("Index");
			}
		}

	}
}
