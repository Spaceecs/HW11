using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11
{
    public static class ArrayExtensions
    {
        public static int[] Filter(this int[] array, Predicate<int> predicate)
        {
            int count = 0;
            foreach (int item in array)
            {
                if (predicate(item))
                {
                    count++;
                }
            }

            int[] result = new int[count];
            int index = 0;
            foreach (int item in array)
            {
                if (predicate(item))
                {
                    result[index++] = item;
                }
            }

            return result;
        }
    }
    public class DaylyTemperature
    {
        public int MinTemp { get; set; }
        public int MaxTemp { get; set; }
        public int Dif { get; set; }
        public DaylyTemperature() { }
        public DaylyTemperature(int minTemp, int maxTemp)
        {
            MinTemp = minTemp;
            MaxTemp = maxTemp;
            Dif = maxTemp - minTemp;
        }
        public override string ToString()
        {
            return $"Min Temperature = {MinTemp}\nMax Temperature = {MaxTemp}\nTemperature Difference = {Dif}";
        }
    }
    class StudentGrades
    {
        public string StudentName { get; set; }
        public int[] Grades { get; set; }

        public int MaxGrade()
        {
            return Grades.Length > 0 ? Grades.Max() : 0;
        }

        public double AverageGrade()
        {
            return Grades.Length > 0 ? Grades.Average() : 0;
        }
    }
}
