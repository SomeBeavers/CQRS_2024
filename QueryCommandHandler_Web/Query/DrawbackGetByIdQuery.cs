
using MediatR;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.Query
{
    public record DrawbackGetByIdQuery(int Id) : IRequest<DrawbackQueryModel>;
}
