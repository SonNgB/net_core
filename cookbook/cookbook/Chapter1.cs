

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

    public class Chapter1
    {
        public void OutputInfomation(object person)
        {
            //if (person is Student student)
            //{
            //    WriteLine($"Student {student.Name} {student.LastName} is enrolled for coursr {String.Join<int>(" ", student.CourseCodes)}");
            //}

            //if (person is Professor professor)
            //{
            //    WriteLine($"Professor {professor.Name} {professor.LastName} teaches {String.Join(" ", professor.TeacherSubject)}");
            //}

            switch (person)
            {
                case Student student:
                    WriteLine($"Student {student.Name} {student.LastName} is enrolled for coursr {String.Join<int>(" ", student.CourseCodes)}");
                    break;
                case Professor professor:
                    WriteLine($"Professor {professor.Name} {professor.LastName} teaches {String.Join(" ", professor.TeacherSubject)}");
                    break;
                case null:
                    WriteLine($"Object {nameof(person)} is null");
                    break;
                default:
                    WriteLine("Unknown object detected");
                    break;
            }

        }
    }

    public class Student
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public List<int> CourseCodes { get; set; }
    }

    public class Professor
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public List<string> TeacherSubject { get; set; }
    }
    #endregion

}
