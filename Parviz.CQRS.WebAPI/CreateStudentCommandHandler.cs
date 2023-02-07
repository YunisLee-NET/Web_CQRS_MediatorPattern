using MediatR;
using Parviz.CQRS.WebAPI.Data;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Parviz.CQRS.WebAPI
{
    public class CreateStudentCommandHandler:IRequestHandler<CreateStudentCommand>
    {
        private readonly StudentContext _context;

        public CreateStudentCommandHandler(StudentContext context)
        {
            _context = context;
        }

        public void Handle(CreateStudentCommand command)
        {
            
        }

        public async Task<Unit> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            _context.Add(new Student { Name = request.Name, Surname = request.Surname, Age = request.Age });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
