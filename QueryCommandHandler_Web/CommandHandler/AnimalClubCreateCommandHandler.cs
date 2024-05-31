
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    internal sealed class AnimalClubCreateCommandHandler(AnimalContext context) : IRequestHandler<AnimalClubCreateCommand, int>
    {
        public async Task<int> Handle(AnimalClubCreateCommand request, CancellationToken cancellationToken)
        {
            // context.Animals.Add(request.AnimalCommandModel.ToAnimal());
            return await context.SaveChangesAsync(cancellationToken);
        }
    }
}
