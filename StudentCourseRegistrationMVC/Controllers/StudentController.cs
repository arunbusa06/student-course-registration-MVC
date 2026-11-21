using Microsoft.AspNetCore.Mvc;
using StudentCourseRegistrationMVC.Models;

namespace StudentCourseRegistrationMVC.Controllers;

public class StudentController : Controller
{
    // In-memory storage as permitted by the activity. Data resets when the app stops.
    private static readonly List<Student> Students = new()
    {
        new Student { Id = 1, Name = "Aarav Patel", Email = "aarav@example.com", Course = "Computer Engineering", Semester = 5 },
        new Student { Id = 2, Name = "Diya Shah", Email = "diya@example.com", Course = "Information Technology", Semester = 3 }
    };

    private static int _nextId = 3;

    // GET: /Student or /Student/Index
    public IActionResult Index()
    {
        return View(Students.OrderBy(s => s.Id).ToList());
    }

    // GET: /Student/Create
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    // POST: /Student/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Student student)
    {
        // Model binding maps submitted form values to the Student object.
        // Data Annotations are checked and their errors are added to ModelState.
        if (!ModelState.IsValid)
        {
            return View(student);
        }

        student.Id = _nextId++;
        Students.Add(student);
        return RedirectToAction(nameof(Index));
    }

    // GET: /Student/Details/1
    public IActionResult Details(int id)
    {
        var student = Students.FirstOrDefault(s => s.Id == id);
        if (student is null)
        {
            return NotFound();
        }

        return View(student);
    }
}
