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
        //static void Main(string[] args)
        //{
        //    Chapter1 ch1 = new Chapter1();
        //    Student student = new Student();
        //    student.Name = "John";
        //    student.LastName = "Kirk";
        //    student.CourseCodes = new List<int> { 203, 202, 101 };
        //    ch1.OutputInfomation(student);
        //    Professor professor = new Professor();
        //    professor.Name = "Luke";
        //    professor.LastName = "Lucky";
        //    professor.TeacherSubject = new List<string> { "Math", "English" };
        //    ch1.OutputInfomation(professor);
        //    ReadLine();
        //}
        #endregion

        #region 5.0 Deconstruction (deconstruction for tuple) 
        //static void Main(string[] args)
        //{
        //    Student student = new Student();
        //    student.Name = "Steve";
        //    student.LastName = "Nguyen";
        //    var (name, lastname) = student;
        //    WriteLine($"hello mr {name} {lastname}");
        //    ReadLine();
        //}
        #endregion

        #region 6.0 Local function
        //static void Main(string[] args)
        //{
        //    Chapter1 ch1 = new Chapter1();
        //    WriteLine($"Sum: {ch1.getSum(1,2)}");
        //    ReadLine();
        //}
        #endregion

        #region 7.0 ref Return and Locals
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            Chapter1 ch1 = new Chapter1();
            int val = ch1.GetLargest(a, b);
            val += 10;

            WriteLine($"{val}  {a}  {b}");

            ref int refval =ref ch1.GetLargest(ref a,ref b); // khi tra ve ad thi gan dia chi cua a vao refval nen khi refval + 10 thi a + 10
            refval += 10;

            WriteLine($"{refval}  {a}  {b}");

            ReadLine();
        }
        #endregion
    }
}
