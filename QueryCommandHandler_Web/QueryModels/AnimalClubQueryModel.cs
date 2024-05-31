
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.QueryModels;

        public class AnimalClubQueryModel
        {
            public int Id { get; set; }
        }

        public static class AnimalClubQueryModelExtensions
        {
    public static AnimalClubQueryModel ToAnimalClubQueryModel(this AnimalClub? animalclub)
    {
        return new AnimalClubQueryModel { Id = 0};
    }
        }
        