
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    internal sealed class AnimalLocationUpdateCommandHandler(AnimalContext context) : IRequestHandler<AnimalLocationUpdateCommand, int>
    {
        public async Task<int> Handle(AnimalLocationUpdateCommand request, CancellationToken cancellationToken)
        {
            // context.Animals.Add(request.AnimalCommandModel.ToAnimal());
            return await context.SaveChangesAsync(cancellationToken);
        }
    }
}
