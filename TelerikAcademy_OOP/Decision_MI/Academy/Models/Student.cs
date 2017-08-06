using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using Academy.Models.Utils.Contracts;
using Academy.Models.Enums;

namespace Academy.Models
{
    public class Student : User, IStudent
    {
        public Student(string username, string track)
            : base(username)
        {
            Track parsed;
            if (!Enum.TryParse(track, out parsed))
            {
                throw new ArgumentException(Constants.trackError);
            }
            this.Track = parsed;
            this.CourseResults = new List<ICourseResult>();
        }

        public Track Track { get; set; }

        public IList<ICourseResult> CourseResults { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("* Student:");
            sb.AppendLine(" - Username: " + this.Username);
            sb.AppendLine(" - Track: " + this.Track);
            sb.AppendLine(" - Course results:");
            sb.Append(this.CourseResults.Count > 0 ? string.Join("\n", this.CourseResults) : Constants.noCourseResults); 

            return sb.ToString();
        }

    }
}
