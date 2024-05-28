using CoreLib_Common;

namespace QueryCommand_App;

public static class Helper
{
    public static AnimalContext GetContext()
    {
        return new AnimalContext();
    }
}