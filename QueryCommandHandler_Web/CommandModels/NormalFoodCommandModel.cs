
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.CommandModels;

public class NormalFoodCommandModel
{
    public string Id { get; set; }
}

public static class NormalFoodCommandModelExtensions
{
    public static NormalFood ToDBNormalFood(this NormalFoodCommandModel NormalFood)
    {
        return new NormalFood()
        {
        };
    }
}
