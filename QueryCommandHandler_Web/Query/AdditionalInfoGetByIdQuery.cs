
using MediatR;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.Query
{
    public record AdditionalInfoGetByIdQuery(int Id) : IRequest<AdditionalInfoQueryModel>;
}
