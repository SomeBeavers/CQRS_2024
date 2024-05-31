
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    internal sealed class NormalFoodCreateCommandHandler(AnimalContext context) : IRequestHandler<NormalFoodCreateCommand, int>
    {
        public async Task<int> Handle(NormalFoodCreateCommand request, CancellationToken cancellationToken)
        {
            // context.Animals.Add(request.AnimalCommandModel.ToAnimal());
            return await context.SaveChangesAsync(cancellationToken);
        }
    }
}
