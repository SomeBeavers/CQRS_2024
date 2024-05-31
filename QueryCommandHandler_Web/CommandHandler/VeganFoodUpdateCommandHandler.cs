
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    internal sealed class VeganFoodUpdateCommandHandler(AnimalContext context) : IRequestHandler<VeganFoodUpdateCommand, int>
    {
        public async Task<int> Handle(VeganFoodUpdateCommand request, CancellationToken cancellationToken)
        {
            // context.Animals.Add(request.AnimalCommandModel.ToAnimal());
            return await context.SaveChangesAsync(cancellationToken);
        }
    }
}
