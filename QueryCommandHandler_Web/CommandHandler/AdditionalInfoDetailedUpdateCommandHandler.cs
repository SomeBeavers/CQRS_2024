
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    internal sealed class AdditionalInfoDetailedUpdateCommandHandler(AnimalContext context) : IRequestHandler<AdditionalInfoDetailedUpdateCommand, int>
    {
        public async Task<int> Handle(AdditionalInfoDetailedUpdateCommand request, CancellationToken cancellationToken)
        {
            // context.Animals.Add(request.AnimalCommandModel.ToAnimal());
            return await context.SaveChangesAsync(cancellationToken);
        }
        public void UseCommon1(JetBrains.Annotations.CommonClasses.Common1 common1)
        {
            common1.Test();
        }
    }
}
