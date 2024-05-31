
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.QueryModels;

        public class PersonQueryModel
        {
            public int Id { get; set; }
        }

        public static class PersonQueryModelExtensions
        {
    public static PersonQueryModel ToPersonQueryModel(this Person? person)
    {
        return new PersonQueryModel { Id = person.Id};
    }
        }
        