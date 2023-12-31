using System.ComponentModel.DataAnnotations;

namespace WebApiGrey.Shared
{
    public class Course
    {
        //[Key]
        //public int CourseId { get; set; }
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        //Navigation Properties
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }




    }
}
