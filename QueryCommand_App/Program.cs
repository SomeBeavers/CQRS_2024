// See https://aka.ms/new-console-template for more information
using QueryCommand_App.Queries;

Console.WriteLine("Hello, World!");
var animal = new GetAnimalByIdQuery().Execute(1);

Console.WriteLine(animal.Id + " " + animal.Name);