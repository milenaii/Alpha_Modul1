using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models
{
    public class VideoResource : LectureResource
    {
        public VideoResource(string name, string url, DateTime uploadedOn)
            : base(name, url)
        {
            this.UploadedOn = uploadedOn;
        }

        public DateTime UploadedOn { get; set; }

        public override string Type()
        {
            return $"Video\n     - Uploaded on: {this.UploadedOn}";
        }
    }
}
