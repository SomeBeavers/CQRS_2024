
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    internal sealed class NormalFoodRemoveCommandHandler(AnimalContext context) : IRequestHandler<NormalFoodRemoveCommand, int>
    {
        public async Task<int> Handle(NormalFoodRemoveCommand request, CancellationToken cancellationToken)
        {
            // context.Animals.Add(request.AnimalCommandModel.ToAnimal());
            return await context.SaveChangesAsync(cancellationToken);
        }
    }
}
