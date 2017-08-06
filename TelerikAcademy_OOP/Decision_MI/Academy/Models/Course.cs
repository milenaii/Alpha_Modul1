using Academy.Models.Contracts;
using Academy.Models.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Models
{
    public class Course : ICourse
    {
        private string name;
        private int lecturesPerWeek;

        public Course(string name, string lecturesPerWeek, string startingDate)
        {
            this.Name = name;
            this.LecturesPerWeek = int.Parse(lecturesPerWeek);

            this.StartingDate = DateParser.Parser(startingDate);
            this.EndingDate = this.StartingDate.AddDays(30);

            this.OnsiteStudents = new List<IStudent>();
            this.OnlineStudents = new List<IStudent>();
            this.Lectures = new List<ILecture>();

        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < Constants.minLengthName || value.Length > Constants.maxLengthName)
                {
                    throw new ArgumentException(Constants.nameErrorMessage);
                }
                this.name = value;
            }
        }
        public int LecturesPerWeek
        {
            get
            {
                return this.lecturesPerWeek;
            }
            set
            {
                if (value < Constants.minLecturesPerWeek || value > Constants.maxLecturesPerWeek)
                {
                    throw new ArgumentException(Constants.lecturePerWeekErrorMessage);
                }
                this.lecturesPerWeek = value;
            }
        }

        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public IList<IStudent> OnsiteStudents { get; private set; }
        public IList<IStudent> OnlineStudents { get; private set; }
        public IList<ILecture> Lectures { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("* Course:");
            sb.AppendLine(" - Name: " + this.Name);
            sb.AppendLine(" - Lectures per week: " + this.LecturesPerWeek);
            sb.AppendLine(" - Starting date: " + this.StartingDate);
            sb.AppendLine(" - Ending date: " + this.EndingDate);
            sb.AppendLine(" - Onsite students: " + this.OnsiteStudents.Count);
            sb.AppendLine(" - Online students: " + this.OnlineStudents.Count);
            sb.AppendLine(" - Lectures:");
            sb.AppendLine(this.Lectures.Count > 0 ? string.Join("\n", this.Lectures) : Constants.noLectures);

            return sb.ToString(); 


        }

    }
}
