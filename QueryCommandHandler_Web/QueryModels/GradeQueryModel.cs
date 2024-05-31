
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.QueryModels;

        public class GradeQueryModel
        {
            public int Id { get; set; }
        }

        public static class GradeQueryModelExtensions
        {
    public static GradeQueryModel ToGradeQueryModel(this Grade? grade)
    {
        return new GradeQueryModel { Id = grade.Id};
    }
        }
        