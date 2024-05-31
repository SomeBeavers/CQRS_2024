
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    internal sealed class DrawbackCreateCommandHandler(AnimalContext context) : IRequestHandler<DrawbackCreateCommand, int>
    {
        public async Task<int> Handle(DrawbackCreateCommand request, CancellationToken cancellationToken)
        {
            // context.Animals.Add(request.AnimalCommandModel.ToAnimal());
            return await context.SaveChangesAsync(cancellationToken);
        }
    }
}
