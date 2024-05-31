using NLog;
using QueryCommand_App.Queries;

namespace QueryCommand_App.Commands;

public record NormalRecord
{
    public NormalRecord(GetBeaverQuery getBeaverQuery)
    {
        var removeAnimalCommand = new RemoveAnimalCommand<GetBeaverQuery>(1, getBeaverQuery);
        removeAnimalCommand.Test(null);
        getBeaverQuery.MethodFromQueryInterface();
        var serializedObject = Newtonsoft.Json.JsonConvert.SerializeObject(getBeaverQuery);

        Logger logger = LogManager.GetCurrentClassLogger();
        logger.Info(serializedObject);
        Helper.GetContext();
    }
}