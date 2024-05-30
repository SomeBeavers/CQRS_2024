using QueryCommand_App.Queries;

namespace QueryCommand_App.Commands;

public record NormalRecord
{
    public NormalRecord(GetBeaverQuery getBeaverQuery)
    {
        var removeAnimalCommand = new RemoveAnimalCommand<GetBeaverQuery>(1, getBeaverQuery);
        removeAnimalCommand.Test();
        getBeaverQuery.MethodFromQueryInterface();
    }
}