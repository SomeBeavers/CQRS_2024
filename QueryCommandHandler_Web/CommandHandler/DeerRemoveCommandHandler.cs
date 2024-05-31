
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    internal sealed class DeerRemoveCommandHandler(AnimalContext context) : IRequestHandler<DeerRemoveCommand, int>
    {
        public async Task<int> Handle(DeerRemoveCommand request, CancellationToken cancellationToken)
        {
            // context.Animals.Add(request.AnimalCommandModel.ToAnimal());
            return await context.SaveChangesAsync(cancellationToken);
        }
    }
}
