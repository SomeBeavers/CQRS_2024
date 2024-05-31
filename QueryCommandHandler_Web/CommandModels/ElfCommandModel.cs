
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.CommandModels;

public class ElfCommandModel
{
    public string Id { get; set; }
}

public static class ElfCommandModelExtensions
{
    public static Elf ToDBElf(this ElfCommandModel Elf)
    {
        return new Elf()
        {
        };
    }
}
