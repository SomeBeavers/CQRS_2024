using DatabaseLib;

namespace QueryCommand_App;

public static class Helper
{
    public static AnimalContext GetContext()
    {
        // BUG: not clear in what Queries and Commands this method is used
        return new AnimalContext();
    }
}