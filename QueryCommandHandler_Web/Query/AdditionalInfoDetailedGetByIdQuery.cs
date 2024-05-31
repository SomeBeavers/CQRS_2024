
using MediatR;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.Query
{
    public record AdditionalInfoDetailedGetByIdQuery(int Id) : IRequest<AdditionalInfoDetailedQueryModel>;
}
