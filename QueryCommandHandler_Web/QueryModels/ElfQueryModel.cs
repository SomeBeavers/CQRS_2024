
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.QueryModels;

        public class ElfQueryModel
        {
            public int Id { get; set; }
        }

        public static class ElfQueryModelExtensions
        {
    public static ElfQueryModel ToElfQueryModel(this Elf? elf)
    {
        return new ElfQueryModel { Id = elf.Id};
    }
        }
        