namespace WebApiGrey.Shared
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Navigation Property
        IList<Course> Courses { get; set; }
        //List<Course> CoursesL { get; set; }

        //public int CourseId { get; set; }
        //public Course Course { get; set; }

        

    }
}
