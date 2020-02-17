using System;

namespace School
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
                int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
            : this(name, studentId, 0, 0) { }

        public Student(string name)
            : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        public void AddGrade(int courseCredits, double grade)
        {
           double qualityScore1 = Gpa * NumberOfCredits;
           double qualityScore2 = grade * courseCredits;
           NumberOfCredits += courseCredits;
           Gpa = (qualityScore1 + qualityScore2) / NumberOfCredits;
        }

        public string GetGradeLevel()
        {
            string gradeLevel = "";
            if (NumberOfCredits >= 0 && NumberOfCredits <= 29)
            {
                gradeLevel = "Freshman";
            }
            if (NumberOfCredits >= 30 && NumberOfCredits <= 59)
            {
                gradeLevel = "Sophomore";

            }
            if (NumberOfCredits >= 60 && NumberOfCredits <= 89)
            {
                gradeLevel = "Junior";

            }
            if (NumberOfCredits >= 90)
            {
                gradeLevel = "Senior";

            }
            return gradeLevel;
        }
    }
}
