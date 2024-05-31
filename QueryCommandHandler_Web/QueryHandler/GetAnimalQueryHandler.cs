using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.Query;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.QueryHandler
{
    internal sealed class GetAnimalQueryHandler(AnimalContext context)
        : IRequestHandler<GetAnimalQuery, AnimalQueryModel>
    {
        public async Task<AnimalQueryModel> Handle(GetAnimalQuery request, CancellationToken cancellationToken)
        {
            return (await context.Animals.FindAsync(request.Id, cancellationToken))!.ToAnimalQueryModel();
        }
    }
}
