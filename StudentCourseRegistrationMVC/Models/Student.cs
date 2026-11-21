using System.ComponentModel.DataAnnotations;

namespace StudentCourseRegistrationMVC.Models;

public class Student
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter the student's name.")]
    [StringLength(60, MinimumLength = 2,
        ErrorMessage = "Name must be between 2 and 60 characters.")]
    [Display(Name = "Student Name")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please enter an email address.")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
    [StringLength(100, ErrorMessage = "Email cannot exceed 100 characters.")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please enter a course.")]
    [StringLength(60, MinimumLength = 2,
        ErrorMessage = "Course must be between 2 and 60 characters.")]
    public string Course { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please enter a semester.")]
    [Range(1, 8, ErrorMessage = "Semester must be between 1 and 8.")]
    public int Semester { get; set; }
}
