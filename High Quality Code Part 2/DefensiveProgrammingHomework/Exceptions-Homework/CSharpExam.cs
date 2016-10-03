using System;

public class CSharpExam : Exam
{
    private int score;

    public CSharpExam(int score)
    {
        this.Score = score;
    }

    public int Score
    {
        get
        {
            return this.score;
        }

        private set
        {
            Validator.ValidateIfNegative(value, "The score");
            this.score = value;
        }
    }

    public override ExamResult Check()
    {
        int minScore = 0;
        int maxScore = 100;
        Validator.IsInRange(this.Score, minScore, maxScore, "The score");

        return new ExamResult(this.Score, minScore, maxScore, "Exam results calculated by score.");
    }
}