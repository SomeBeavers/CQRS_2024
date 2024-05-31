
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.CommandModels;

public class VeganFoodCommandModel
{
    public string Id { get; set; }
}

public static class VeganFoodCommandModelExtensions
{
    public static VeganFood ToDBVeganFood(this VeganFoodCommandModel VeganFood)
    {
        return new VeganFood()
        {
        };
    }
}
