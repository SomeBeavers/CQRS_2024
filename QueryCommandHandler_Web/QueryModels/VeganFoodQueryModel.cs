
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.QueryModels;

        public class VeganFoodQueryModel
        {
            public int Id { get; set; }
        }

        public static class VeganFoodQueryModelExtensions
        {
    public static VeganFoodQueryModel ToVeganFoodQueryModel(this VeganFood? veganfood)
    {
        return new VeganFoodQueryModel { Id = veganfood.Id};
    }
        }
        