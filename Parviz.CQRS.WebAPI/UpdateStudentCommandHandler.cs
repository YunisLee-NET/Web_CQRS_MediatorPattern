using MediatR;
using Parviz.CQRS.WebAPI.Data;
using System.Threading;
using System.Threading.Tasks;

namespace Parviz.CQRS.WebAPI
{
    public class UpdateStudentCommandHandler:IRequestHandler<UpdateStudentCommand>
    {
        private readonly StudentContext _studentContext;

        public UpdateStudentCommandHandler(StudentContext studentContext)
        {
            _studentContext = studentContext;
        }

        //public void Handle(UpdateStudentCommand command)
        //{
        //    var getId = _studentContext.Set<Student>().Find(command.Id);
        //    command.Surname = getId.Surname;
        //    command.Name = getId.Name;
        //    command.Age = getId.Age;
        //    _studentContext.SaveChanges();
        //}

        public async Task<Unit> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            var update = await _studentContext.Students.FindAsync(request.Id);
            update.Name = request.Name;
            update.Surname = request.Surname;
            update.Age = request.Age;
            await _studentContext.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
