using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models
{
    public class Trainer : User, ITrainer
    {
        public Trainer(string username, string commaSeparatedTechnologies)
            :base (username)
        {
            this.Technologies = new List<string>(commaSeparatedTechnologies.Split(','));
        }

        public IList<string> Technologies { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("* Trainer: ");
            sb.AppendLine(" - Username: " + this.Username);
            sb.AppendLine(" - Technologies: " + string.Join("; ",this.Technologies));

            return sb.ToString().TrimEnd();
        }

    }
}
