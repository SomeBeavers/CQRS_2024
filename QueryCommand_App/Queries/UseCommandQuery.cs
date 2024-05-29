namespace QueryCommand_App.Queries;

public class UseCommandQuery
{
    public UseCommandClass UseCommandClass { get; } = new();

    public void Execute()
    {
        UseCommandClass.UseCommandMethod(out var addAnimalCommand);
        
        Console.WriteLine(addAnimalCommand.ToString());
    }
}