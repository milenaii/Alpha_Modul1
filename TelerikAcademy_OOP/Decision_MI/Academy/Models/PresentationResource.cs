using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models
{
    public class PresentationResource : LectureResource
    {
        public PresentationResource(string name, string url)
            : base(name, url)
        {

        }

        public override string Type()
        {
            return "Presentation";
        }

    }
}
