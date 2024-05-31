
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    internal sealed class JobDrawbackRemoveCommandHandler(AnimalContext context) : IRequestHandler<JobDrawbackRemoveCommand, int>
    {
        public async Task<int> Handle(JobDrawbackRemoveCommand request, CancellationToken cancellationToken)
        {
            // context.Animals.Add(request.AnimalCommandModel.ToAnimal());
            return await context.SaveChangesAsync(cancellationToken);
        }
    }
}
