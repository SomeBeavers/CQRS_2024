
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.CommandModels;

public class ClubCommandModel
{
    public string Id { get; set; }
}

public static class ClubCommandModelExtensions
{
    public static Club ToDBClub(this ClubCommandModel Club)
    {
        return new Club()
        {
        };
    }
}
