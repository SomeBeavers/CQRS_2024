
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.Query;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.QueryHandler
{
    internal sealed class AnimalLocationGetByIdQueryHandler(AnimalContext context)
        : IRequestHandler<AnimalLocationGetByIdQuery, AnimalLocationQueryModel>
    {
        public async Task<AnimalLocationQueryModel> Handle(AnimalLocationGetByIdQuery request, CancellationToken cancellationToken)
        {
            return null;
        }
    }
}
        