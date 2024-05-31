
using MediatR;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.Query
{
    public record GradeGetByIdQuery(int Id) : IRequest<GradeQueryModel>;
}
