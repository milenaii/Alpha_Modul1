using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models
{
    public static class Constants
    {
        //Course cl
        public const int minLengthName = 3;
        public const int maxLengthName = 45;
        public const string nameErrorMessage = "The name of the course must be between 3 and 45 symbols!";

        public const int minLecturesPerWeek = 1;
        public const int maxLecturesPerWeek = 7;
        public const string lecturePerWeekErrorMessage = "The number of lectures per week must be between 1 and 7!";
        public const string noLectures = "  * There are no lectures in this course!";

        //User cl
        public const int minLengthUsername = 3;
        public const int maxLengthUsername = 16;
        public const string usernameErrorMessage = "User's username should be between 3 and 16 symbols long!";

        //Student cl
        public const string trackError = "The provided track is not valid!";
        public const string noCourseResults = "  * User has no course results!";

        //Course Result cl
        public const string examPointsError = "Course result's exam points should be between 0 and 1000!";
        public const string coursePointsError = "Course result's course points should be between 0 and 125!";
        //Lecture cl

        public const int minLectureName = 5;
        public const int maxLectureName = 30;

        public const string nameLectureError = "Lecture's name should be between 5 and 30 symbols long!";

        // Lecture resourse cl
        public const int minLectureResourseName = 3;
        public const int maxLectureResourseName = 15;
        public const string lectureResourseError = "Resource name should be between 3 and 15 symbols long!";

        public const int minResourseUrl = 5;
        public const int maxResourseUrl = 150;
        public const string resourseError = "Resource url should be between 5 and 150 symbols long!";
            
            }
}
