
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    internal sealed class ConsequenceUpdateCommandHandler(AnimalContext context) : IRequestHandler<ConsequenceUpdateCommand, int>
    {
        public async Task<int> Handle(ConsequenceUpdateCommand request, CancellationToken cancellationToken)
        {
            // context.Animals.Add(request.AnimalCommandModel.ToAnimal());
            return await context.SaveChangesAsync(cancellationToken);
        }
    }
}
