using Microsoft.AspNetCore.Mvc;
using Student_Managemet_System.Models;
using Student_Managemet_System.ViewModel;

namespace Student_Managemet_System.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var students = _context.student.ToList();
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(StudentViewModel student)
        {
            try
            {
                DateTime? CurrentDate = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("India Standard Time"));
                if (student.Id > 0 )
                {
                    var existingstudent = _context.student.Find(student.Id);

                    existingstudent.FirstName = student.FirstName;
                    existingstudent.LastName = student.LastName;
                    existingstudent.Address = student.Address;
                    existingstudent.City = student.City;
                    existingstudent.Username = student.Username;
                    existingstudent.Password = student.Password;
                    existingstudent.std_id = student.std_id;
                    existingstudent.Email = student.Email;
                    existingstudent.Rank = student.Rank;
                    existingstudent.Document = student.Document;
                    existingstudent.Phone = student.Phone;
                    existingstudent.Education = student.Education;
                    existingstudent.Description = student.Description;
                    existingstudent.ModifiedDate = CurrentDate;

                    _context.student.Update(existingstudent);
                } else
                {
                    var students = new Student
                    {
                        FirstName = student.FirstName,
                        LastName = student.LastName,
                        Address = student.Address,
                        City = student.City,
                        Username = student.Username,
                        Password = student.Password,
                        std_id = student.std_id,
                        Email = student.Email,
                        Rank = student.Rank,
                        Document = student.Document,
                        Phone = student.Phone,
                        Education = student.Education,
                        Description = student.Description,
                        CreatedDate = CurrentDate,
                    };
                    _context.student.Add(students);
                }
                _context.SaveChanges();
                return RedirectToAction("Index");
            } catch (Exception)
            {
                return View(student);
            }
        }

        public IActionResult Edit(int id)
        {
            var student = _context.student.FirstOrDefault(x => x.Id == id);
            var studentviewmodel = new StudentViewModel
            {
                Id = student.Id,
                FirstName = student.FirstName,
                LastName = student.LastName,
                Address = student.Address,
                City = student.City,
                Username = student.Username,
                Password = student.Password,
                std_id = student.std_id,
                Email = student.Email,
                Rank = student.Rank,
                Document = student.Document,
                Phone = student.Phone,
                Education = student.Education,
                Description = student.Description,
                CreateBy = student.CreateBy,
            };
            return View("Create" ,studentviewmodel);
        }

        public IActionResult Details(int id)
        {
            var student = _context.student.FirstOrDefault(x => x.Id == id);
            var studentviewmodel = new StudentViewModel
            {
                Id = student.Id,
                FirstName = student.FirstName,
                LastName = student.LastName,
                Address = student.Address,
                City = student.City,
                Username = student.Username,
                Password = student.Password,
                std_id = student.std_id,
                Email = student.Email,
                Rank = student.Rank,
                Document = student.Document,
                Phone = student.Phone,
                Education = student.Education,
                Description = student.Description,
                CreateBy = student.CreateBy,
            };
            return View(studentviewmodel);
        }
        public IActionResult Delete(int id)
        {
            var student = _context.student.Find(id);
            if (student == null)
                return NotFound();

            _context.student.Remove(student);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
