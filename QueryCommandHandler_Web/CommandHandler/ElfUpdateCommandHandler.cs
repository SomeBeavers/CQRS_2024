
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    internal sealed class ElfUpdateCommandHandler(AnimalContext context) : IRequestHandler<ElfUpdateCommand, int>
    {
        public async Task<int> Handle(ElfUpdateCommand request, CancellationToken cancellationToken)
        {
            // context.Animals.Add(request.AnimalCommandModel.ToAnimal());
            return await context.SaveChangesAsync(cancellationToken);
        }
    }
}
