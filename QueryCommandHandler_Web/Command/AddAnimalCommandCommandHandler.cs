using DatabaseLib;
using MediatR;
using Microsoft.EntityFrameworkCore;
using QueryCommand_App.CommandModels;
using QueryCommandHandler_Web.QueryModels;

namespace ConsoleApp_Core
{
    internal sealed class AddAnimalCommandCommandHandler(AnimalContext context) : IRequestHandler<AddAnimalCommandCommand, AnimalQueryModel>
    {
        public async Task<AnimalQueryModel> Handle(AddAnimalCommandCommand request, CancellationToken cancellationToken)
        {
            context.Animals.Add(request.animalCommandModel.ToAnimal());
            await context.SaveChangesAsync(cancellationToken);
            return (await context.Animals.Where(animal =>
                string.Equals(animal.Name, request.animalCommandModel.Name, StringComparison.Ordinal)).FirstOrDefaultAsync(cancellationToken: cancellationToken)).ToAnimalQueryModel();
        }
    }
}