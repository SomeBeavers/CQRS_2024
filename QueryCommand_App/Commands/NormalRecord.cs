using QueryCommand_App.Queries;

namespace QueryCommand_App.Commands;

public record NormalRecord
{
    public NormalRecord(GetBeaverQuery getBeaverQuery)
    {
        var removeAnimalCommand = new RemoveAnimal<GetBeaverQuery>(1, getBeaverQuery);
        removeAnimalCommand.Test(null);
        getBeaverQuery.MethodFromQueryInterface();
    }
}