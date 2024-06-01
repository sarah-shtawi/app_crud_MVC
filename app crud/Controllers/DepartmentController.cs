using app_crud.Data;
using app_crud.Models;
using Microsoft.AspNetCore.Mvc;

namespace app_crud.Controllers
{
    public class DepartmentController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var departments = context.Departments.ToList();
            return View("Index", departments);
        }

        public IActionResult Details(int id)
        {
           var dep =  context.Departments.Find(id);
            return View("Details",dep);
        }
        public IActionResult Create()
        {
            return View("CreateDep");
        }
        public IActionResult AddDep(Department dep )
        {
            context.Departments.Add(dep);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id) 
        {
            var dep = context.Departments.Find(id);
            context.Departments.Remove(dep);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
