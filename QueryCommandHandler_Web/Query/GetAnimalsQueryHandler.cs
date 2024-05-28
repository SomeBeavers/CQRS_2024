using DatabaseLib;
using MediatR;
using Microsoft.EntityFrameworkCore;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.Query
{
    internal sealed class GetAnimalsQueryHandler(AnimalContext context)
        : IRequestHandler<GetAnimalsQuery, AnimalQueryModel[]>
    {
        public async Task<AnimalQueryModel[]> Handle(GetAnimalsQuery request, CancellationToken cancellationToken)
        {
            var animals = await context.Animals.ToListAsync(cancellationToken: cancellationToken);

            return animals.Select(animal => animal.ToAnimalQueryModel()).ToArray();
        }
    }
}
