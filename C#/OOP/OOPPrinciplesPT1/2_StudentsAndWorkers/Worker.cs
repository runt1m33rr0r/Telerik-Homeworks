namespace _2_StudentsAndWorkers
{
    using System;

    public class Worker : Human
    {
        private double salary;
        private int workHours;

        public double WeekSalary
        {
            get
            {
                return this.salary;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Week salary can not be negative number!");
                }

                this.salary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHours;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The work hours can not be negative number!");
                }

                this.workHours = value;
            }
        }

        public Worker(string firstName, string lastName, double weekSalary, int workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double MoneyPerHour()
        {
            double result = this.salary / (this.workHours * 5);

            return result;
        }
    }
}
