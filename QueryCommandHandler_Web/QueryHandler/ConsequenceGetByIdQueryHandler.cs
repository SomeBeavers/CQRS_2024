
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.Query;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.QueryHandler
{
    internal sealed class ConsequenceGetByIdQueryHandler(AnimalContext context)
        : IRequestHandler<ConsequenceGetByIdQuery, ConsequenceQueryModel>
    {
        public async Task<ConsequenceQueryModel> Handle(ConsequenceGetByIdQuery request, CancellationToken cancellationToken)
        {
            return null;
        }
    }
}
        