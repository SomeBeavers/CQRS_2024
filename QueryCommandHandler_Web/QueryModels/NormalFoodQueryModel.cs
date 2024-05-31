
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.QueryModels;

        public class NormalFoodQueryModel
        {
            public int Id { get; set; }
        }

        public static class NormalFoodQueryModelExtensions
        {
    public static NormalFoodQueryModel ToNormalFoodQueryModel(this NormalFood? normalfood)
    {
        return new NormalFoodQueryModel { Id = normalfood.Id};
    }
        }
        