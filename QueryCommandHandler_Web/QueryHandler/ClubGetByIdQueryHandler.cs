
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.Query;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.QueryHandler
{
    internal sealed class ClubGetByIdQueryHandler(AnimalContext context)
        : IRequestHandler<ClubGetByIdQuery, ClubQueryModel>
    {
        public async Task<ClubQueryModel> Handle(ClubGetByIdQuery request, CancellationToken cancellationToken)
        {
            return (await context.Clubs.FindAsync(request.Id, cancellationToken))!.ToClubQueryModel();
        }
    }
}
        