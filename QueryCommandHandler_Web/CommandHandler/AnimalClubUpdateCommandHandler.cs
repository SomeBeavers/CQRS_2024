
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    internal sealed class AnimalClubUpdateCommandHandler(AnimalContext context) : IRequestHandler<AnimalClubUpdateCommand, int>
    {
        public async Task<int> Handle(AnimalClubUpdateCommand request, CancellationToken cancellationToken)
        {
            // context.Animals.Add(request.AnimalCommandModel.ToAnimal());
            return await context.SaveChangesAsync(cancellationToken);
        }
    }
}
