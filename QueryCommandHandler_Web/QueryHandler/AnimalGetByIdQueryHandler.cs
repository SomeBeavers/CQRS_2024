
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.Query;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.QueryHandler
{
    internal sealed class AnimalGetByIdQueryHandler(AnimalContext context)
        : IRequestHandler<AnimalGetByIdQuery, AnimalQueryModel>
    {
        public async Task<AnimalQueryModel> Handle(AnimalGetByIdQuery request, CancellationToken cancellationToken)
        {
            return (await context.Animals.FindAsync(request.Id, cancellationToken))!.ToAnimalQueryModel();
        }
        public void UseCommon1(JetBrains.Annotations.CommonClasses.Common1 common1)
        {
            common1.Test();
        }
    }
}
        