using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message;
            int numberOfRepetitions;

            Console.Write("Введите ваше сообщение: ");
            message = Console.ReadLine();
            Console.Write("Введите количество повторений сообщения: ");
            numberOfRepetitions = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberOfRepetitions; i++)
            {
                Console.WriteLine(message);
            }
        }
    }
}
