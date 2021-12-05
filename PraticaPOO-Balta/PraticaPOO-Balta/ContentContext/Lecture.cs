using PraticaPOO_Balta.ContentContext.Enums;
using PraticaPOO_Balta.SharedContext;

namespace PraticaPOO_Balta.ContentContext
{
    public class Lecture : BaseContent
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public double DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}
