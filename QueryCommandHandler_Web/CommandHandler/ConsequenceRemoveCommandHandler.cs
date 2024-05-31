
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    internal sealed class ConsequenceRemoveCommandHandler(AnimalContext context) : IRequestHandler<ConsequenceRemoveCommand, int>
    {
        public async Task<int> Handle(ConsequenceRemoveCommand request, CancellationToken cancellationToken)
        {
            // context.Animals.Add(request.AnimalCommandModel.ToAnimal());
            return await context.SaveChangesAsync(cancellationToken);
        }
    }
}
