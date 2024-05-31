
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.CommandModels;

public class AnimalClubCommandModel
{
    public int Id { get; set; }
}

public static class AnimalClubCommandModelExtensions
{
    public static AnimalClub ToDBAnimalClub(this AnimalClubCommandModel AnimalClub)
    {
        return new AnimalClub()
        {
        };
    }
}
