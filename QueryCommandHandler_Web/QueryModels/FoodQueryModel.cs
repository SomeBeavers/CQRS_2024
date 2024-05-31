
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.QueryModels;

        public class FoodQueryModel
        {
            public int Id { get; set; }
        }

        public static class FoodQueryModelExtensions
        {
    public static FoodQueryModel ToFoodQueryModel(this Food? food)
    {
        return new FoodQueryModel { Id = food.Id};
    }
        }
        