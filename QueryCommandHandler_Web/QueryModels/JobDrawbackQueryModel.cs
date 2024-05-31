
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.QueryModels;

        public class JobDrawbackQueryModel
        {
            public int Id { get; set; }
        }

        public static class JobDrawbackQueryModelExtensions
        {
    public static JobDrawbackQueryModel ToJobDrawbackQueryModel(this JobDrawback? jobdrawback)
    {
        return new JobDrawbackQueryModel { Id = 0};
    }
        }
        