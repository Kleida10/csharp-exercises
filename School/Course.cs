using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    class Course
    {
       
        private readonly bool isEnrolled;

        public List<string> Required { get; set; }
        public List<string> Optional { get; set; }

    }
}
