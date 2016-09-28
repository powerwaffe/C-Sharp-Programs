using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28Sep_16_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = { 89, 78, 93, 94 };
            int sum = 0;
            //for (int i = 0; i < grades.Length; i++)
            //  sum += grades[i];
            foreach (int grade in grades)
                sum += grade;
            Console.WriteLine(sum);
            Console.WriteLine("Press any key to continue:");
            Console.ReadKey();
        }
    }
}
