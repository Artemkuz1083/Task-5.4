using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 5.4");
            Console.Write("Введите числа через пробел которые будут в массиве: ");
            HomeWork4(Console.ReadLine());
            Console.WriteLine("Программа завершена");
        }

        public static void HomeWork4(string str)
        {
            string[] array = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> result = new List<int>();
            double db = 0;
            foreach (var item in array)
            {
                if (int.TryParse(item, out int intNumber) && intNumber > 0)
                {
                    result.Add(Factorial(intNumber));
                }
                else if (int.TryParse(item, out int maynoseIntNumber))
                {
                    result.Add(maynoseIntNumber);
                }
                else if (double.TryParse(item, out double doubleNumber))
                {
                    db = Math.Round(doubleNumber, 2);
                    string strDouble = Convert.ToString(Convert.ToString(db).Last());
                    var lastDouble = Convert.ToInt32(strDouble);
                    result.Add(lastDouble);
                }
            }
            Console.WriteLine($"Новый массив: {string.Join(", ", result)}");
            Console.WriteLine($"Старый массив: {string.Join(", ", array)}");
        }

        public static int Factorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            return number * Factorial(number - 1);
        }
    }
}
