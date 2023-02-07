using MediatR;
using Microsoft.EntityFrameworkCore;
using Parviz.CQRS.WebAPI.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Parviz.CQRS.WebAPI
{
    public class GetAllStudentsQueryHandler:IRequestHandler<GetAllStudentsQuery,IEnumerable<GetAllStudentsQueryResult>>
    {
        private readonly StudentContext _studentContext;

        public GetAllStudentsQueryHandler(StudentContext studentContext)
        {
            _studentContext = studentContext;
        }

        //public IEnumerable<GetAllStudentsQueryResult> Handle(GetAllStudentsQuery query)
        //{

        //}

        //IEnumerable adi qaydada yazsaq, AsEnumerable-dan istifade edeceksen, yox asinxron proqramlasdirma edirsense, ToListAsync olacaq

        public async Task<IEnumerable<GetAllStudentsQueryResult>> Handle(GetAllStudentsQuery request, CancellationToken cancellationToken)
        {
            var allStudent = await _studentContext.Set<Student>().Select(x => new GetAllStudentsQueryResult { Name = x.Name, Surname = x.Surname, Age = x.Age }).AsNoTracking().ToListAsync();
            return allStudent;
        }
    }
}
