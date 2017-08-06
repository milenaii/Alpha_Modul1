using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models
{
    public class HomeworkResource : LectureResource
    {
        public HomeworkResource(string name, string url, DateTime dueDate)
            : base(name, url)
        {
            this.DueDate = dueDate;
        }

        public DateTime DueDate
        { get;  private set; }

        public override string Type()
        {
            return $"Homework\n     - Due date: {this.DueDate}";
        }

    }
}
