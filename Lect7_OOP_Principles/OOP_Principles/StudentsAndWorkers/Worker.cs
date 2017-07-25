using System;

namespace StudentsAndWorkers
{
    public class Worker : Human
    {

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary { get; private set; }
        public double WorkHoursPerDay { get; private set; }

        public double MoneyPerHour()
        {
            return  this.WeekSalary / (WorkHoursPerDay * 5);
        }

        public override string ToString()
        {
            return base.ToString() + MoneyPerHour();
        }

    }
}
