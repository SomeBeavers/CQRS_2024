using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Scriban;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        var workspace = new AdhocWorkspace();
        var project = workspace.AddProject("DatabaseLib", LanguageNames.CSharp);
        var documents = Directory.GetFiles("C:\\Work\\Test Projects\\CQRS_2024\\DatabaseLib", "*.cs", SearchOption.AllDirectories)
            .Select(file => project.AddDocument(Path.GetFileName(file), File.ReadAllText(file)));

        project = documents.Last().Project;

        var compilation = await project.GetCompilationAsync();

//        var template = Template.Parse(@"
//public class {{ model_name }}CreateCommand
//{
//    // Add properties here
//}
//    public record AddAnimalCommand(AnimalCommandModel AnimalCommandModel) : IRequest<int>;

//public class {{ model_name }}CreateCommandHandler : IRequestHandler<{{ model_name }}CreateCommand, {{ model_name }}>
//{
//    private readonly DbContext _context;

//    public {{ model_name }}CreateCommandHandler(DbContext context)
//    {
//        _context = context;
//    }

//    public async Task<{{ model_name }}> Handle({{ model_name }}CreateCommand request, CancellationToken cancellationToken)
//    {
//        var entity = new {{ model_name }}
//        {
//            // Assign properties here
//        };

//        _context.Add(entity);
//        await _context.SaveChangesAsync(cancellationToken);

//        return entity;
//    }
//}");

        List<Template> templates = new();
        var createCommand = Template.Parse(@"
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record {{ model_name }}{{ action_name }}Command({{ model_name }}CommandModel {{ model_name }}CommandModel) : IRequest<int>;
}
");


    //    var updateCommand = Template.Parse(@"
    //public record {{ model_name }}UpdateCommand({{ model_name }}CommandModel {{ model_name }}CommandModel) : IRequest<int>;");
    //    var removeCommand = Template.Parse(@"
    //public record {{ model_name }}RemoveCommand({{ model_name }}CommandModel {{ model_name }}CommandModel) : IRequest<int>;");

        templates= [createCommand/*, updateCommand, removeCommand*/];

//        var createModel = Template.Parse(@"
//using DatabaseLib.Model;

//namespace QueryCommandHandler_Web.CommandModels;

//public class {{ model_name }}CommandModel
//{
//    public string Id { get; set; }
//}

//public static class {{ model_name }}CommandModelExtensions
//{
//    public static {{ model_name }} ToDB{{ model_name }}(this {{ model_name }}CommandModel " + @"{{ model_name }}".ToLower() + @")
//    {
//        return new {{ model_name }}()
//        {
//        };
//    }
//}
//");
//        templates = [createModel];
        foreach (var document in documents)
        {
            var syntaxTree = await document.GetSyntaxTreeAsync();
            var modelClasses = syntaxTree.GetRoot().DescendantNodes().OfType<ClassDeclarationSyntax>();

            foreach (var modelClass in modelClasses)
            {
                var className = modelClass.Identifier.Text;
                foreach (var template in templates)
                {
                    var source1 = template.Render(new { model_name = className, action_name = "Create" });
                    WriteToFile(source1, className, "Create", "Command");

                    var source2 = template.Render(new { model_name = className, action_name = "Update" });
                    WriteToFile(source2, className, "Update", "Command");
                    var source3 = template.Render(new { model_name = className, action_name = "Remove" });
                    WriteToFile(source3, className, "Remove", "Command");

                    //var source4 = template.Render(new { model_name = className });
                    //WriteToFile(source4, className, "CommandModel");


                }
            }
        }
    }

    private static void WriteToFile(string? source, string className, string actionName, string command)
    {
        var fileName = Template.Parse(@"{{ model_name }}{{ action_name }}" +command+ @".cs");
        var fileNameString = fileName.Render(new { model_name = className, action_name = actionName });
        Directory.CreateDirectory("GeneratedCode4");
        File.WriteAllText("GeneratedCode4/"+fileNameString, source);

        Console.WriteLine($"Generated file: {fileNameString}");
    }
}
