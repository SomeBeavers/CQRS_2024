
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.Query;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.QueryHandler
{
    internal sealed class NotMappedTextGetByIdQueryHandler(AnimalContext context)
        : IRequestHandler<NotMappedTextGetByIdQuery, NotMappedTextQueryModel>
    {
        public async Task<NotMappedTextQueryModel> Handle(NotMappedTextGetByIdQuery request, CancellationToken cancellationToken)
        {
            return null;
        }
    }
}
        