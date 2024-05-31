
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    internal sealed class VeganFoodRemoveCommandHandler(AnimalContext context) : IRequestHandler<VeganFoodRemoveCommand, int>
    {
        public async Task<int> Handle(VeganFoodRemoveCommand request, CancellationToken cancellationToken)
        {
            // context.Animals.Add(request.AnimalCommandModel.ToAnimal());
            return await context.SaveChangesAsync(cancellationToken);
        }
    }
}
