using MediatR;

namespace ConsoleApp_Core
{
    // Include properties to be used as input for the query
    public record GetAnimalQuery(int Id) : IRequest<GetAnimalQueryResponse>;
}
