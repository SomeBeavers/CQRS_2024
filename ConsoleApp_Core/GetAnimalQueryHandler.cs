﻿using System.Resources;
using CoreLib_Common;
using CoreLib_Common.Model;
using MediatR;

namespace ConsoleApp_Core
{
    internal sealed class GetAnimalQueryHandler : IRequestHandler<GetAnimalQuery, Animal>
    {
        public async Task<Animal> Handle(GetAnimalQuery request, CancellationToken cancellationToken)
        {
            var context = new AnimalContext();
            //return new GetAnimalQueryResponse(){}
            return await context.Animals.FindAsync(request.Id, cancellationToken);
        }
    }
}
