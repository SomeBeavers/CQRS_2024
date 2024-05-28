using System.Resources;
using CoreLib_Common;
using CoreLib_Common.Model;
using MediatR;
using QueryCommand_App.QueryModels;

namespace ConsoleApp_Core
{
    internal sealed class GetAnimalQueryHandler : IRequestHandler<GetAnimalQuery, AnimalQueryModel>
    {
        private readonly AnimalContext _context;
        public GetAnimalQueryHandler(AnimalContext context)
        {
            _context = context;
        }
        public async Task<AnimalQueryModel> Handle(GetAnimalQuery request, CancellationToken cancellationToken)
        {
            //var context = new AnimalContext();
            //return new GetAnimalQueryResponse(){}
            return (await _context.Animals.FindAsync(request.Id, cancellationToken)).ToAnimalQueryModel();
        }
    }
}
