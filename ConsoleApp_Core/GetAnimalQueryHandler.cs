using System.Resources;
using MediatR;

namespace ConsoleApp_Core
{
    internal sealed class GetAnimalQueryHandler : IRequestHandler<GetAnimalQuery, GetAnimalQueryResponse>
    {
        public Task<GetAnimalQueryResponse> Handle(GetAnimalQuery request, CancellationToken cancellationToken)
        {
            //return new GetAnimalQueryResponse(){}
            return null;
        }
    }
}
