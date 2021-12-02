using PraticaPOO_Balta.ContentContext.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PraticaPOO_Balta.ContentContext.Module;

namespace PraticaPOO_Balta.ContentContext
{
    public class Course : Content
    {
        public Course()
        {
            Modules = new List<Module>();
        }
        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
        public double DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }   
}
