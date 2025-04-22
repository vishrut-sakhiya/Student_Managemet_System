using Microsoft.AspNetCore.Mvc;
using Student_Managemet_System.Models;

namespace Student_Managemet_System.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, int password)
        {
            var user = _context.student.Where(s => s.Username == username && s.Password == password);
            if (user != null)
            {
                return RedirectToAction("Index","Student");
            }
            return View();
        }
    }
}
