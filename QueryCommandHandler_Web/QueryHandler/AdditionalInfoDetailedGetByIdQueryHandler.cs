
using DatabaseLib;
using Lib;
using MediatR;
using QueryCommandHandler_Web.Query;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.QueryHandler
{
    internal sealed class AdditionalInfoDetailedGetByIdQueryHandler(AnimalContext context)
        : IRequestHandler<AdditionalInfoDetailedGetByIdQuery, AdditionalInfoDetailedQueryModel>
    {
        public async Task<AdditionalInfoDetailedQueryModel> Handle(AdditionalInfoDetailedGetByIdQuery request, CancellationToken cancellationToken)
        {
            return (await context.AdditionalInfoDetailed.FindAsync(request.Id, cancellationToken))!.ToAdditionalInfoDetailedQueryModel();
        }
        public void UseCommon1(JetBrains.Annotations.CommonClasses.Common1 common1)
        {
            LibClass.LibMethod();
            common1.Test();
        }
    }
}
        