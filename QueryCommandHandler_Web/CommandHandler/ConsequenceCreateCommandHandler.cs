
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    internal sealed class ConsequenceCreateCommandHandler(AnimalContext context) : IRequestHandler<ConsequenceCreateCommand, int>
    {
        public async Task<int> Handle(ConsequenceCreateCommand request, CancellationToken cancellationToken)
        {
            // context.Animals.Add(request.AnimalCommandModel.ToAnimal());
            return await context.SaveChangesAsync(cancellationToken);
        }
    }
}
