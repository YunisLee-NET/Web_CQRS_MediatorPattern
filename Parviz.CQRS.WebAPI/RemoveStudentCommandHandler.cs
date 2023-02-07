using MediatR;
using Parviz.CQRS.WebAPI.Data;
using System.Threading;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Parviz.CQRS.WebAPI
{
    public class RemoveStudentCommandHandler: IRequestHandler<RemoveStudentCommand>
    {
        private readonly StudentContext _studentContext;

        public RemoveStudentCommandHandler(StudentContext studentContext)
        {
            _studentContext = studentContext;
        }

        public void Handle(RemoveStudentCommand command)
        {
            
        }

        public async Task<Unit> Handle(RemoveStudentCommand request, CancellationToken cancellationToken)
        {
            var deletedId = await _studentContext.Students.FindAsync(request.Id);
            _studentContext.Remove(deletedId);
            await _studentContext.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
