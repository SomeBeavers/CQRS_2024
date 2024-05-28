using DatabaseLib;

namespace QueryCommand_App;

public static class Helper
{
    public static AnimalContext GetContext()
    {
        return new AnimalContext();
    }
}