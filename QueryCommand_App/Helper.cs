using DatabaseLib;

namespace QueryCommand_App;

public static class Helper
{
    // BUG: this method is called from AddAnimalCommand and new AnimalContext() is called from GetAnimalByIdQuery
    public static AnimalContext GetContext()
    {
        // BUG: not clear in what Queries and Commands this method is used
        return new AnimalContext();
    }

    public static string GetComponentType()
    {
        return "Animal";
    }
}