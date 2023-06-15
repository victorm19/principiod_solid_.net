using Microsoft.AspNetCore.Mvc;

namespace DependencyInversion.Controllers;

[ApiController, Route("student")]
public class StudentController : ControllerBase
{
    private readonly IStudentRepository _studentRepository;
    private readonly ILogbook _logbook;

    public StudentController(IStudentRepository studentRepository, ILogbook logbook)
    {
        _studentRepository = studentRepository;
        _logbook = logbook;
    }

    [HttpGet]
    public IEnumerable<Student> Get()
    {
        _logbook.Add($"returning student's list");
        return _studentRepository.GetAll();
    }

    [HttpPost]
    public void Add([FromBody] Student student)
    {
        _studentRepository.Add(student);
        _logbook.Add($"The Student {student.Fullname} have been added");
    }
}
