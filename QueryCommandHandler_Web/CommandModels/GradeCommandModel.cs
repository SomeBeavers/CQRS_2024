
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.CommandModels;

public class GradeCommandModel
{
    public int Id { get; set; }
}

public static class GradeCommandModelExtensions
{
    public static Grade ToDBGrade(this GradeCommandModel Grade)
    {
        return new Grade()
        {
        };
    }
}
