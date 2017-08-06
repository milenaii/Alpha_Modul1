using Academy.Models.Utils.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;
using Academy.Models.Enums;

namespace Academy.Models
{
    public class CourseResult : ICourseResult
    {
        private ICourse course;
        private float examPoints;
        private float coursePoints;

        public CourseResult(ICourse course, string examPoints, string coursePoints)
        {
            this.Course = course;
            this.ExamPoints = float.Parse(examPoints);
            this.CoursePoints = float.Parse(coursePoints);

            this.Grade = DetermineGrade(ExamPoints, CoursePoints);

        }

        public ICourse Course
        {
            get
            {
                return this.course;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Course should not be null!");
                }
                this.course = value;
            }
        }
        public float ExamPoints
        {
            get
            {
                return this.examPoints;
            }
            set
            {
                if (value < 0 || value > 1000)
                {
                    throw new ArgumentNullException(Constants.examPointsError);
                }
                this.examPoints = value;
                      
            }
        }

        public float CoursePoints
        {
            get
            {
                return this.coursePoints;
            }
            set
            {
                if (value < 0 || value > 125)
                {
                    throw new ArgumentNullException(Constants.coursePointsError);
                }
                this.coursePoints = value;

            }
        }

        public Grade Grade { get; private set; }

        private Grade DetermineGrade(float examPoints, float coursePoints)
        {
            if (examPoints >= 65 || coursePoints >= 75)
            {
                return Grade.Excellent;
            }
            if ((examPoints < 60 && examPoints >= 30) || (coursePoints < 75 && coursePoints >= 45))
            {
                return Grade.Passed;
            }
            return Grade.Failed;
        }

        public override string ToString()
        {
            return string.Format($"  * {this.Course.Name}: Points - {this.CoursePoints}, Grade - {this.Grade}");
        }


    }
}
