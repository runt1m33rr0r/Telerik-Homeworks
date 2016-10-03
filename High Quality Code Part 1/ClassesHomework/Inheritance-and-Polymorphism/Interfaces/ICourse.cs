namespace InheritanceAndPolymorphism.Interfaces
{
    using System.Collections.Generic;

    public interface ICourse
    {
        string Name { get; }

        string TeacherName { get; }

        ICollection<string> Students { get; }

        string GetStudentsAsString();
    }
}
