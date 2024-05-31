using DatabaseLib;

using MediatR;
using QueryCommandHandler_Web.Command;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.CommandHandler
{
    internal sealed class AddAnimalCommandHandler(AnimalContext context) : IRequestHandler<AddAnimalCommand, int>
    {
        public async Task<int> Handle(AddAnimalCommand request, CancellationToken cancellationToken)
        {
            // BUG: guess why
            context.Animals.Add(request.AnimalCommandModel.ToAnimal());
            return await context.SaveChangesAsync(cancellationToken);
            //return (await context.Animals.Where(animal =>
            //    string.Equals(animal.Name, request.AnimalCommandModel.Name, StringComparison.Ordinal)).FirstOrDefaultAsync(cancellationToken)).ToAnimalQueryModel();
        }

        public void UseCommon1(JetBrains.Annotations.CommonClasses.Common1 common1)
        {
            common1.Test();
        }
    }
}