
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.QueryModels;

        public class ClubQueryModel
        {
            public int Id { get; set; }
        }

        public static class ClubQueryModelExtensions
        {
    public static ClubQueryModel ToClubQueryModel(this Club? club)
    {
        return new ClubQueryModel { Id = club.Id};
    }
        }
        