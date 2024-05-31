
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    internal sealed class AnimalLocationCreateCommandHandler(AnimalContext context) : IRequestHandler<AnimalLocationCreateCommand, int>
    {
        public async Task<int> Handle(AnimalLocationCreateCommand request, CancellationToken cancellationToken)
        {
            // context.Animals.Add(request.AnimalCommandModel.ToAnimal());
            return await context.SaveChangesAsync(cancellationToken);
        }
    }
}
