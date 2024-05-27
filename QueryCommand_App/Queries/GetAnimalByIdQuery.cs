using CoreLib_Common;
using QueryCommand_App.QueryModels;

namespace QueryCommand_App.Queries;

public class GetAnimalByIdQuery
{
    public AnimalQueryModel Execute(int id)
    {
        var context = new AnimalContext();
        // TODO: completion 
        var animal = context.Animals.Find(id);
        if (animal != null)
        {
            return animal.ToAnimalQueryModel();
        }

        return null;
    }
}