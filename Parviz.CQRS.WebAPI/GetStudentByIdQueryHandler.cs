using MediatR;
using Parviz.CQRS.WebAPI.Data;
using System.Threading;
using System.Threading.Tasks;

namespace Parviz.CQRS.WebAPI
{
    public class GetStudentByIdQueryHandler:IRequestHandler<GetStudentByIdQuery,GetStudentByIdQueryResult>
    {
        private readonly StudentContext _studentContext;

        public GetStudentByIdQueryHandler(StudentContext studentContext)
        {
            _studentContext = studentContext;
        }

        //public GetStudentByIdQueryResult Handle(GetStudentByIdQuery getStudent)
        //{

        //}

        public async Task<GetStudentByIdQueryResult> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _studentContext.Set<Student>().FindAsync(request.Id);
            return new GetStudentByIdQueryResult
            {
                Age = result.Age,
                Name = result.Name,
                Surname = result.Surname
            };
        }
    }
}
