
using MediatR;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.Query
{
    public record AnimalGetByIdQuery(int Id) : IRequest<AnimalQueryModel>
    {
        public void MethodFromQuery()
        {
            throw new NotImplementedException();
        }
    }
}
