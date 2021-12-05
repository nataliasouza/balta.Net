using PraticaPOO_Balta.NotificationContext;
using PraticaPOO_Balta.SharedContext;

namespace PraticaPOO_Balta.ContentContext
{
    public class CareerItem : BaseContent
    {
        public CareerItem(int order, 
            string title, 
            string description, 
            Course course)
        {
            if (course == null)
                AddNotification(new Notification("Course", "Curso Inválido"));

            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}
