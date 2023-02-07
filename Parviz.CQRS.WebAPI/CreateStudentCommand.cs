using MediatR;

namespace Parviz.CQRS.WebAPI
{
    public class CreateStudentCommand:IRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
}
