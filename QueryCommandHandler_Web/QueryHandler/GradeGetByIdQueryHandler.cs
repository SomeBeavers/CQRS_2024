
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.Query;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.QueryHandler
{
    internal sealed class GradeGetByIdQueryHandler(AnimalContext context)
        : IRequestHandler<GradeGetByIdQuery, GradeQueryModel>
    {
        public async Task<GradeQueryModel> Handle(GradeGetByIdQuery request, CancellationToken cancellationToken)
        {
            return (await context.Grades.FindAsync(request.Id, cancellationToken))!.ToGradeQueryModel();
        }
    }
}
        