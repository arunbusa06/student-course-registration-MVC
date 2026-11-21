# Student Course Registration System — ASP.NET Core MVC

A Visual Studio-ready implementation of the Marwadi University **Self-Learning Activity – ASP.NET Core MVC**.

## Requirements
- Visual Studio 2022 (17.8 or later recommended)
- **ASP.NET and web development** workload
- .NET 8 SDK

## Open and run in Visual Studio
1. Extract the ZIP file to a normal folder (do not run it from inside the ZIP).
2. Open `StudentCourseRegistrationMVC.sln` in Visual Studio.
3. If Visual Studio asks to restore packages, allow it. This project uses the ASP.NET Core shared framework and has no extra NuGet packages.
4. In the toolbar, select `https` or `http` and press **F5** (or **Ctrl+F5**).
5. The home page opens. Use **Register Student** to open the form, then **Student List** to view registrations.

If .NET 8 is not installed, install the .NET 8 SDK and the ASP.NET workload through Visual Studio Installer.

## Features
- Home page
- Student registration form
- Student list
- Student details page
- MVC Model, Controller and Razor Views
- Default route: `{controller=Home}/{action=Index}/{id?}`
- Form POST, model binding, anti-forgery token and server-side validation
- Data Annotations: `[Required]`, `[StringLength]`, `[Range]`, `[EmailAddress]`
- `ModelState.IsValid` check and validation messages
- Controller-to-View data passing
- In-memory `static List<Student>`; no database is required

## Project structure
```text
StudentCourseRegistrationMVC/
├── Controllers/
│   ├── HomeController.cs
│   └── StudentController.cs
├── Models/
│   └── Student.cs
├── Views/
│   ├── Home/Index.cshtml
│   ├── Shared/_Layout.cshtml
│   ├── Student/Index.cshtml
│   ├── Student/Create.cshtml
│   ├── Student/Details.cshtml
│   ├── _ViewImports.cshtml
│   └── _ViewStart.cshtml
├── wwwroot/css/site.css
├── Program.cs
├── appsettings.json
└── StudentCourseRegistrationMVC.csproj
```

## Important implementation points
- `Student.cs` defines Id, Name, Email, Course and Semester plus validation attributes.
- `StudentController.Index()` sends the student collection to `Views/Student/Index.cshtml`.
- `Create()` GET displays the form. `Create(Student student)` POST receives form values through model binding.
- When `ModelState.IsValid` is false, the same form is returned with validation errors. If valid, the student is stored and the app redirects to `Index()`.
- `Details(int id)` finds a student and returns the Details view, or HTTP 404 if the ID does not exist.

## Important note about storage
The activity explicitly permits an in-memory list and says a database is not mandatory. Registrations are therefore temporary: they reset when the application stops or restarts. This is intentional for this activity.

## Screenshots to capture for submission
The activity asks for screenshots of the working application, including validation errors. Run the app and capture these yourself:
1. Home page.
2. Student Registration form.
3. Validation errors: submit the empty form; capture the displayed required-field errors. Also try an invalid email or semester outside 1–8.
4. Student List after a successful registration.
5. Student Details page opened from the list.

Suggested Windows shortcut: `Win + Shift + S`. Save the images in a folder named `Submission-Screenshots` and include them with your report. Do not submit mock screenshots; use screenshots from your own running Visual Studio application.

## Deliverables checklist
- [x] Source code project (ZIP excludes `bin` and `obj`)
- [x] Short report: `Report/Activity-Report.docx` and `Report/Activity-Report.md`
- [ ] Actual application screenshots (capture after running locally)
- [x] Learning resources and references listed in the report

## Learning resources
- Microsoft Learn — ASP.NET Core MVC: https://learn.microsoft.com/aspnet/core/mvc/overview
- Microsoft Learn — Models and validation: https://learn.microsoft.com/aspnet/core/mvc/models/validation
- Microsoft Learn — Routing: https://learn.microsoft.com/aspnet/core/mvc/controllers/routing
- Microsoft Learn — Razor syntax: https://learn.microsoft.com/aspnet/core/mvc/views/razor
