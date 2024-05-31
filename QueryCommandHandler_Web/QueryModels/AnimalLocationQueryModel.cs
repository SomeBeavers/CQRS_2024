
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.QueryModels;

        public class AnimalLocationQueryModel
        {
            public int Id { get; set; }
        }

        public static class AnimalLocationQueryModelExtensions
        {
    public static AnimalLocationQueryModel ToAnimalLocationQueryModel(this AnimalLocation? animallocation)
    {
        return new AnimalLocationQueryModel { Id = 0};
    }
        }
        