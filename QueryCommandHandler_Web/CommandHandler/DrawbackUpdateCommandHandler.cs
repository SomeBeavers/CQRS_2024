
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    internal sealed class DrawbackUpdateCommandHandler(AnimalContext context) : IRequestHandler<DrawbackUpdateCommand, int>
    {
        public async Task<int> Handle(DrawbackUpdateCommand request, CancellationToken cancellationToken)
        {
            // context.Animals.Add(request.AnimalCommandModel.ToAnimal());
            return await context.SaveChangesAsync(cancellationToken);
        }
    }
}
