﻿using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.Command;
using QueryCommandHandler_Web.CommandModels;
using QueryCommandHandler_Web.QueryHandler;

namespace QueryCommandHandler_Web.CommandHandler
{
    internal sealed class AddBeaverCommandHandler(AnimalContext context) : IRequestHandler<AddBeaverCommand, int>
    {
        public async Task<int> Handle(AddBeaverCommand request, CancellationToken cancellationToken)
        {
            context.Beavers.Add(request.BeaverCommandModel.ToDBBeaver());
            return await context.SaveChangesAsync(cancellationToken);
        }

        public GetAnimalQueryHandler queryField = new(context);

        public void Test()
        {
            //var handle = queryField.Handle(null, default);
            //GetAnimalQueryHandler queryField3 = new(context);
            //NewFunction();

            //void NewFunction()
            //{
            //    GetAnimalQueryHandler queryField2 = new(context);
            //}
        }

        public void UseCommon1(JetBrains.Annotations.CommonClasses.Common1 common1)
        {
            common1.Test();
        }
    }
}