
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.Query;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.QueryHandler
{
    internal sealed class DrawbackGetByIdQueryHandler(AnimalContext context)
        : IRequestHandler<DrawbackGetByIdQuery, DrawbackQueryModel>
    {
        public async Task<DrawbackQueryModel> Handle(DrawbackGetByIdQuery request, CancellationToken cancellationToken)
        {
            return (await context.Drawbacks.FindAsync(request.Id, cancellationToken))!.ToDrawbackQueryModel();
        }
    }
}
        