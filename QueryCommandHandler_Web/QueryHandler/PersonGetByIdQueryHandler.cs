
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.Query;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.QueryHandler
{
    internal sealed class PersonGetByIdQueryHandler(AnimalContext context)
        : IRequestHandler<PersonGetByIdQuery, PersonQueryModel>
    {
        public async Task<PersonQueryModel> Handle(PersonGetByIdQuery request, CancellationToken cancellationToken)
        {
            return (await context.Persons.FindAsync(request.Id, cancellationToken))!.ToPersonQueryModel();
        }
    }
}
        