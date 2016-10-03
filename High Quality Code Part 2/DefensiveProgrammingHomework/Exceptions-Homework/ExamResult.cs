using System;

public class ExamResult
{
    private int grade;
    private int minGrade;
    private int maxGrade;
    private string comments;

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade
    {
        get
        {
            return this.minGrade;
        }

        private set
        {
            Validator.ValidateIfNegative(value, "The grade");
            this.grade = value;
        }
    }

    public int MinGrade
    {
        get
        {
            return this.minGrade;
        }

        private set
        {
            Validator.ValidateIfNegative(value, "The minimal grade");
            this.minGrade = value;
        }
    }

    public int MaxGrade
    {
        get
        {
            return this.maxGrade;
        }

        private set
        {
            Validator.ValidateIfNegative(value, "The maximal grade");
            Validator.ValidateIfLessOrEqualTo(value, this.MinGrade, "The maximal grade");
            this.maxGrade = value;
        }
    }

    public string Comments
    {
        get
        {
            return this.comments;
        }

        private set
        {
            Validator.ValidateNullOrEmptyString(value, "The comments");
            this.comments = value;
        }
    }
}
