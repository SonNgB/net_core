using System;
using static System.Console;

namespace cookbook
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Chapter1 ch1 = new Chapter1();
            var (average, studentCount) = ch1.GetAverageAndCount(scores);
            WriteLine($"Average was {average} accross {studentCount} students");
            ReadLine();
        }
    }
}
