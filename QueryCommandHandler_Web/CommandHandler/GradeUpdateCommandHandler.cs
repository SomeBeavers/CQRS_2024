
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    internal sealed class GradeUpdateCommandHandler(AnimalContext context) : IRequestHandler<GradeUpdateCommand, int>
    {
        public async Task<int> Handle(GradeUpdateCommand request, CancellationToken cancellationToken)
        {
            // context.Animals.Add(request.AnimalCommandModel.ToAnimal());
            return await context.SaveChangesAsync(cancellationToken);
        }
    }
}
