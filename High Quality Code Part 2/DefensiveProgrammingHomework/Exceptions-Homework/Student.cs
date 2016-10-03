using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{
    private string firstName;
    private string lastName;

    public Student(string firstName, string lastName, IList<Exam> exams = null)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    public IList<Exam> Exams { get; set; }

    public string FirstName
    {
        get
        {
            return this.firstName;
        }

        private set
        {
            Validator.ValidateNullOrEmptyString(value, "The student first name");
            this.firstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return this.lastName;
        }

        private set
        {
            Validator.ValidateNullOrEmptyString(value, "The student last name");
            this.lastName = value;
        }
    }


    public IList<ExamResult> CheckExams()
    {
        Validator.ValidateNull(this.Exams, "The student exams");
        this.CheckIfNoExams();

        IList<ExamResult> results = new List<ExamResult>();
        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].Check());
        }

        return results;
    }

    public double CalcAverageExamResultInPercents()
    {
        Validator.ValidateNull(this.Exams, "The student exams");
        this.CheckIfNoExams();

        double[] examScore = new double[this.Exams.Count];
        IList<ExamResult> examResults = CheckExams();
        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] = 
                ((double)examResults[i].Grade - examResults[i].MinGrade) / 
                (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }

    private void CheckIfNoExams()
    {
        if (this.Exams.Count == 0)
        {
            throw new InvalidOperationException("The student has no exams!");
        }
    }
}
