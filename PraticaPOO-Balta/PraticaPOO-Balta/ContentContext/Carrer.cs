using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticaPOO_Balta.ContentContext
{
    public class Carrer : Content
    {
        public Carrer()
        {
            Items = new List<CarrerItem>();
        }
        public IList<CarrerItem>Items { get; set; }
        public int TotalCourses => Items.Count;       
    }    
}
