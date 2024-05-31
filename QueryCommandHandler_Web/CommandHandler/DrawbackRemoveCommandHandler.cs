
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    internal sealed class DrawbackRemoveCommandHandler(AnimalContext context) : IRequestHandler<DrawbackRemoveCommand, int>
    {
        public async Task<int> Handle(DrawbackRemoveCommand request, CancellationToken cancellationToken)
        {
            // context.Animals.Add(request.AnimalCommandModel.ToAnimal());
            return await context.SaveChangesAsync(cancellationToken);
        }
    }
}
