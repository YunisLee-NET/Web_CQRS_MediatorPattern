using MediatR;

namespace Parviz.CQRS.WebAPI
{
    public class GetStudentByIdQuery:IRequest<GetStudentByIdQueryResult>
    {
        public int Id { get; set; }

        public GetStudentByIdQuery(int id)
        {
            Id = id;
        }
    }
}
