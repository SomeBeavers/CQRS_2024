
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.QueryModels;

        public class DrawbackQueryModel
        {
            public int Id { get; set; }
        }

        public static class DrawbackQueryModelExtensions
        {
    public static DrawbackQueryModel ToDrawbackQueryModel(this Drawback? drawback)
    {
        return new DrawbackQueryModel { Id = drawback.Id};
    }
        }
        