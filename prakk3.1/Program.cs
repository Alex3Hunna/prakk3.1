using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace prakk3._1
{
    internal class Program
    {
        class MyIntList
        {
            private List<int> numberList = new List<int>();
            public double Average
            {
                get
                {
                    return CalculateAverage();
                }
            }

            public void AddNumber(int number)
            {
                numberList.Add(number);
            }

            public void RemoveNumber(int number)
            {

                numberList.Remove(number);
            }

            private double CalculateAverage()
            {
                int sum = 0;
                foreach (int number in numberList) { sum += number; }
                return sum / (double)numberList.Count;

            }
            static void Main(string[] args)
            {
                MyIntList numbers = new MyIntList();
                numbers.AddNumber(1);
                numbers.AddNumber(2);
                numbers.AddNumber(8);

                Console.WriteLine(numbers.Average);
                Console.ReadKey(true);

            }
        }
    }
}
