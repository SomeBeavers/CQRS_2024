using DatabaseLib;
using MediatR;
using Microsoft.EntityFrameworkCore;
using QueryCommand_App.CommandModels;
using QueryCommandHandler_Web.QueryModels;

namespace ConsoleApp_Core
{
    internal sealed class AddAnimalCommandHandler(AnimalContext context) : IRequestHandler<AddAnimalCommand, int>
    {
        public async Task<int> Handle(AddAnimalCommand request, CancellationToken cancellationToken)
        {
            // BUG: guess why
            context.Animals.Add(request.animalCommandModel.ToAnimal());
            return await context.SaveChangesAsync(cancellationToken);
            //return (await context.Animals.Where(animal =>
            //    string.Equals(animal.Name, request.animalCommandModel.Name, StringComparison.Ordinal)).FirstOrDefaultAsync(cancellationToken)).ToAnimalQueryModel();
        }
    }
}