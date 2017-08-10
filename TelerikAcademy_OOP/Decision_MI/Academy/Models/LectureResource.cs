using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models
{
    public abstract class LectureResource : ILectureResource
    {
        private string name;
        private string url;

        public LectureResource(string name, string url)
        {
            this.Name = name;
            this.Url = url;
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
                    throw new ArgumentException(Constants.lectureResourseError);
                }
                this.name = value;
            }
        }

        public string Url
        {
            get
            {
                return this.url;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < Constants.minResourseUrl || value.Length > Constants.maxResourseUrl)
                {
                    throw new ArgumentException(Constants.resourseError);
                }
                this.url = value;
            }
        }

        public abstract string Type();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("    * Resource:");
            sb.AppendLine($"     - Name: {this.Name}");
            sb.AppendLine($"     - Url: {this.Url}");
            sb.AppendLine($"     - Type: {this.Type()}");

            return sb.ToString();
        }

    }
}
