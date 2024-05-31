
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    internal sealed class AnimalLocationRemoveCommandHandler(AnimalContext context) : IRequestHandler<AnimalLocationRemoveCommand, int>
    {
        public async Task<int> Handle(AnimalLocationRemoveCommand request, CancellationToken cancellationToken)
        {
            // context.Animals.Add(request.AnimalCommandModel.ToAnimal());
            return await context.SaveChangesAsync(cancellationToken);
        }
    }
}
