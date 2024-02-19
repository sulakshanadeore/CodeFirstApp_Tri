using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibForCodeFirstDemo;
namespace CodeFirstApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var context = new LibForCodeFirstDemo.CompanyDBContext();
            context.Emps.Add(new Employee {EmpName="Anil",EmailAdd="anil@gmail.com",Age=30 });
            context.SaveChanges();
            context.Emps.Add(new Employee { EmpName = "Sunil", EmailAdd = "sunil@gmail.com", Age = 20 });
            context.SaveChanges();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}