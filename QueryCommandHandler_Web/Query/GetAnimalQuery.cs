﻿using MediatR;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.Query
{
    public record GetAnimalQuery(int Id) : IRequest<AnimalQueryModel>;
}
