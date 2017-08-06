using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Utils;

namespace Academy.Models
{
    public class Lecture : ILecture
    {
        private string name;
        //private ITrainer trainer;


        public Lecture(string name, string date, ITrainer Trainer)
        {
            this.Name = name;
            this.Date = DateParser.Parser(date);
            this.Trainer = Trainer;

            this.Resources = new List<ILectureResource>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < Constants.minLectureName || value.Length > Constants.maxLectureName)
                {
                    throw new ArgumentException(Constants.nameLectureError);
                }
                this.name = value;
            }
        }

        public DateTime Date { get; set; }

        public ITrainer Trainer { get; set; }

        public IList<ILectureResource> Resources { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" * Lecture:");
            sb.AppendLine($" - Name: {this.Name}");
            sb.AppendLine($" - Date: {this.Date}");
            sb.AppendLine($" - Trainer username: {this.Trainer.Username}");
            sb.AppendLine($" - Resources:");
            sb.Append($"  * There are no resources in this lecture.");

            return sb.ToString();
        }
    }
}
