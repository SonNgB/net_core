

using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace cookbook
{

    #region 0.2 tuples
    //public class Chapter1
    //{
    //    public (double average, int studentCount, bool belowAverage) GetAverageAndCount(int[] scores, int threshold)
    //    {
    //        var returnTuple = (ave: 0D, sCount: 0, subAve: true);

    //        returnTuple = ((double)scores.Sum() / scores.Count(), scores.Count(), returnTuple.ave.CheckIfBelowAverage(threshold));

    //        return returnTuple;
    //    }
    //}

    //public static class ExtensionMethods
    //{
    //    public static bool CheckIfBelowAverage(this double classAverage, int threshold)
    //    {
    //        if (classAverage < threshold)
    //        {
    //            return true;
    //        }
    //        else
    //        {
    //            return false;
    //        }
    //    }
    //}
    #endregion

    #region 3.0 Pattern matching

    //public class Chapter1
    //{
    //    public void OutputInfomation(object person)
    //    {
    //        //if (person is Student student)
    //        //{
    //        //    WriteLine($"Student {student.Name} {student.LastName} is enrolled for coursr {String.Join<int>(" ", student.CourseCodes)}");
    //        //}

    //        //if (person is Professor professor)
    //        //{
    //        //    WriteLine($"Professor {professor.Name} {professor.LastName} teaches {String.Join(" ", professor.TeacherSubject)}");
    //        //}

    //        switch (person)
    //        {
    //            case Student student:
    //                WriteLine($"Student {student.Name} {student.LastName} is enrolled for coursr {String.Join<int>(" ", student.CourseCodes)}");
    //                break;
    //            case Professor professor:
    //                WriteLine($"Professor {professor.Name} {professor.LastName} teaches {String.Join(" ", professor.TeacherSubject)}");
    //                break;
    //            case null:
    //                WriteLine($"Object {nameof(person)} is null");
    //                break;
    //            default:
    //                WriteLine("Unknown object detected");
    //                break;
    //        }

    //    }
    //}

    //public class Student
    //{
    //    public string Name { get; set; }
    //    public string LastName { get; set; }
    //    public List<int> CourseCodes { get; set; }
    //}

    //public class Professor
    //{
    //    public string Name { get; set; }
    //    public string LastName { get; set; }
    //    public List<string> TeacherSubject { get; set; }
    //}
    #endregion

    #region 5.0 Deconstructor
    //public class Chapter1
    //{

    //}

    //public class Student
    //{
    //    public string Name { get; set; }
    //    public string LastName { get; set; }
    //    public List<int> CourseCode { get; set; }       
    //}

    //public static class ExtentionMethodClass
    //{
    //    public static void Deconstruct(this Student student , out string name, out string lastName)
    //    {
    //        name = student.Name;
    //        lastName = student.LastName;
    //    }
    //}
    #endregion

    #region 6.0 Local function
    //public class Chapter1
    //{
    //    public int getSum(int a, int b)
    //    {
    //        int result = 0;

    //        result = calc(a, b);

    //        int calc(int x, int y)
    //        {
    //            return x + y;
    //        }

    //        result = calc(5, 6);

    //        return result;
    //    }
    //}
    #endregion

    #region  7.0 Ref return and locals
    public class Chapter1
    {
        public int GetLargest(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public ref int GetLargest( ref int a,ref int b)
        {
            if (a > b)
            {
                return ref a;
            }
            else
            {
                return ref b;
            }
        }
    }
    #endregion
}
