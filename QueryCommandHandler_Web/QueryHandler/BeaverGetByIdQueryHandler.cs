
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.Query;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.QueryHandler
{
    internal sealed class BeaverGetByIdQueryHandler(AnimalContext context)
        : IRequestHandler<BeaverGetByIdQuery, BeaverQueryModel>
    {
        public async Task<BeaverQueryModel> Handle(BeaverGetByIdQuery request, CancellationToken cancellationToken)
        {
            return (await context.Beavers.FindAsync(request.Id, cancellationToken))!.ToBeaverQueryModel();
        }
        public void UseCommon1(JetBrains.Annotations.CommonClasses.Common1 common1)
        {
            common1.Test();
        }
    }
}
        