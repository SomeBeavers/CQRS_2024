
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.Query;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.QueryHandler
{
    internal sealed class AnimalClubGetByIdQueryHandler(AnimalContext context)
        : IRequestHandler<AnimalClubGetByIdQuery, AnimalClubQueryModel>
    {
        public async Task<AnimalClubQueryModel> Handle(AnimalClubGetByIdQuery request, CancellationToken cancellationToken)
        {
            return null;
        }
        public void UseCommon1(JetBrains.Annotations.CommonClasses.Common1 common1)
        {
            common1.Test();
        }
    }
}
