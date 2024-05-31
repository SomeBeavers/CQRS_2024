
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    internal sealed class NotMappedTextRemoveCommandHandler(AnimalContext context) : IRequestHandler<NotMappedTextRemoveCommand, int>
    {
        public async Task<int> Handle(NotMappedTextRemoveCommand request, CancellationToken cancellationToken)
        {
            // context.Animals.Add(request.AnimalCommandModel.ToAnimal());
            return await context.SaveChangesAsync(cancellationToken);
        }
    }
}
