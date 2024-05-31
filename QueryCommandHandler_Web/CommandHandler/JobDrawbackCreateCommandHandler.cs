
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    internal sealed class JobDrawbackCreateCommandHandler(AnimalContext context) : IRequestHandler<JobDrawbackCreateCommand, int>
    {
        public async Task<int> Handle(JobDrawbackCreateCommand request, CancellationToken cancellationToken)
        {
            // context.Animals.Add(request.AnimalCommandModel.ToAnimal());
            return await context.SaveChangesAsync(cancellationToken);
        }
    }
}
