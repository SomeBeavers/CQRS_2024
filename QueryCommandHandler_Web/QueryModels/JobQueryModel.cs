
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.QueryModels;

        public class JobQueryModel
        {
            public int Id { get; set; }
        }

        public static class JobQueryModelExtensions
        {
    public static JobQueryModel ToJobQueryModel(this Job? job)
    {
        return new JobQueryModel { Id = job.Id};
    }
        }
        