using DatabaseLib;

using MediatR;
using QueryCommandHandler_Web.Command;
using QueryCommandHandler_Web.CommandModels;
using QueryCommandHandler_Web.Query;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.CommandHandler
{
    internal sealed class AddAnimalCommandHandler(AnimalContext context, IMediator Mediator) : IRequestHandler<AddAnimalCommand, int>
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

            //common1.Test();
        }

        private async Task<AnimalQueryModel> GetAnimal(AnimalGetByIdQuery animalGetByIdQuery)
        {
            var x = true ? null: animalGetByIdQuery!;
            NewClass.NewMethod(animalGetByIdQuery);
            return await Mediator.Send(animalGetByIdQuery!);
        }
    }
}