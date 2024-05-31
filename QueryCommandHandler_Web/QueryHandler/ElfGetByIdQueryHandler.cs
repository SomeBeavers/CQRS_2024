
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.Query;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.QueryHandler
{
    internal sealed class ElfGetByIdQueryHandler(AnimalContext context)
        : IRequestHandler<ElfGetByIdQuery, ElfQueryModel>
    {
        public async Task<ElfQueryModel> Handle(ElfGetByIdQuery request, CancellationToken cancellationToken)
        {
            return (await context.Elves.FindAsync(request.Id, cancellationToken))!.ToElfQueryModel();
        }
    }
}
        