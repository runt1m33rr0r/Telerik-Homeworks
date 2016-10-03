namespace _1_SchoolClasses.School
{
    using System.Collections.Generic;

    public class School
    {
        public School()
        {
            this.Classes = new List<Class>();
        }

        public List<Class> Classes { get; set; }
    }
}
