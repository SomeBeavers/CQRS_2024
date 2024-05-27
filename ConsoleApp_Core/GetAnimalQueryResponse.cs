using CoreLib_Common.Model;
using MediatR;
namespace ConsoleApp_Core
{
    public class GetAnimalQueryResponse
    {
        public Animal Animal { get; set; }
    }
}
