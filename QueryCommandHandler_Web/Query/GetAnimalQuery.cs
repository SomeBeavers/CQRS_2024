using CoreLib_Common.Model;
using MediatR;
using QueryCommand_App.QueryModels;

namespace ConsoleApp_Core
{
    // Include properties to be used as input for the query
    public record GetAnimalQuery(int Id) : IRequest<AnimalQueryModel>;
}
