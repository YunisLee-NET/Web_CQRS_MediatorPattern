using MediatR;

namespace Parviz.CQRS.WebAPI
{
    public class RemoveStudentCommand:IRequest
    {
        public int Id { get; set; }

        public RemoveStudentCommand(int id)
        {
            Id = id;
        }
    }
}
