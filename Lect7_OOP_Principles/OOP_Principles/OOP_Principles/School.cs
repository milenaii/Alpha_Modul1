using System;
using System.Collections.Generic;


namespace OOP_Principles
{
    public class School
    {
        private List<Classes> classes;

        public School(List<Classes> classes)
        {
            this.Classes = classes;
        }

        public List<Classes> Classes
        {
            get
            {
                return this.classes;
            }
            private set
            {
                this.classes = value;
            }
        }


    }
}
