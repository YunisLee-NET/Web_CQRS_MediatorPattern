using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Parviz.CQRS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        //private readonly GetStudentByIdQueryHandler _idStudent;
        //private readonly GetAllStudentsQueryHandler _allStudent;
        //private readonly CreateStudentCommandHandler _createStudent;
        //private readonly RemoveStudentCommandHandler _removeStudent;
        //private readonly UpdateStudentCommandHandler _updateStudent;


        //public StudentsController(GetStudentByIdQueryHandler idStudent, GetAllStudentsQueryHandler allStudent, CreateStudentCommandHandler createStudent, RemoveStudentCommandHandler removeStudent, UpdateStudentCommandHandler updateStudent)
        //{
        //    _idStudent = idStudent;
        //    _allStudent = allStudent;
        //    _createStudent = createStudent;
        //    _removeStudent = removeStudent;
        //    _updateStudent = updateStudent;
        //}

        private readonly IMediator _mediator;

        public StudentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudent(int id)
        {
            var data = await _mediator.Send(new GetStudentByIdQuery(id));
            return Ok(data);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStudents()
        {
            var result = await _mediator.Send(new GetAllStudentsQuery());
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewStudent(CreateStudentCommand addStudent)
        {
            var result = await _mediator.Send(addStudent);
            return Ok(addStudent.Name + "adli telebe ugurla elave edildi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var result = await _mediator.Send(new RemoveStudentCommand(id));
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStudent(UpdateStudentCommand updateCommand)
        {
            var result=await _mediator.Send(updateCommand);
            return Ok("Melumat ugurla yenilendi");
        }

        //[HttpGet]
        //public IActionResult GetAllStudent()
        //{
        //    var result = _allStudent.Handle(new GetAllStudentsQuery());
        //    return Ok(result);
        //}

        //[HttpPost]
        //public IActionResult CreatedStudent(CreateStudentCommand command)
        //{
        //    _createStudent.Handle(command);
        //    return Ok("Telebe ugurla elave edildi");
        //}

        //[HttpDelete("{id}")]
        //public IActionResult RemovedStudent(int id)
        //{
        //   _removeStudent.Handle(new RemoveStudentCommand(id));
        //    return NoContent();
        //}

        //[HttpPut("{id}")]
        //public IActionResult UpdatedStudent(UpdateStudentCommand updatecommand)
        //{
        //    _updateStudent.Handle(updatecommand);
        //    return Ok();
        //}
    }
}

