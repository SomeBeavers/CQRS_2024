using QueryCommandHandler_Web.Query;

namespace QueryCommandHandler_Web.CommandHandler;

public sealed class NewClass
{
    public static void NewMethod(AnimalGetByIdQuery animalGetByIdQuery)
    {
        GetMethod();

        void GetMethod()
        {
            animalGetByIdQuery.MethodFromQuery();
        }
    }
}