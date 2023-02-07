using MediatR;
using System.Collections.Generic;

namespace Parviz.CQRS.WebAPI
{
    public class GetAllStudentsQuery:IRequest<IEnumerable<GetAllStudentsQueryResult>>
    {
    }
}
