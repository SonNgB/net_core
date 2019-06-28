using System;
using System.Collections.Generic;
using static System.Console;
using static System.Math;

namespace cookbook
{
    class Program
    {
        #region 2.0 tuples
        //static void Main(string[] args)
        //{
        //    int[] scores = { 17, 46, 39, 62, 81, 79, 52, 24, 49 };
        //    Chapter1 ch1 = new Chapter1();
        //    int threshold = 40;
        //    var (average, studentCount, belowAverage) = ch1.GetAverageAndCount(scores, threshold);
        //    WriteLine($"Average was {Round(average, 2)} accross {studentCount} students. {(average < threshold ? "1" : "2")}");
        //    ReadLine();
        //}
        #endregion

        #region 3.0 Pattern Matching
        static void Main(string[] args)
        {
            Chapter1 ch1 = new Chapter1();
            Student student = new Student();
            student.Name = "John";
            student.LastName = "Kirk";
            student.CourseCodes = new List<int> { 203, 202, 101 };
            ch1.OutputInfomation(student);
            Professor professor = new Professor();
            professor.Name = "Luke";
            professor.LastName = "Lucky";
            professor.TeacherSubject = new List<string> { "Math", "English" };
            ch1.OutputInfomation(professor);
            ReadLine();
        }
        #endregion
    }
}
