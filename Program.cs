using System;

namespace Itog_CSharp_Start
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Задача Итоговой работы:
            Написать программу, которая из имеющегося массива строк формирует другой массив из строк, длина которых <= 3 символа.
            Первоначальный массив можно ввести с клавиатуры (наш вариант), либо задать на старте выполнения алгоритма.
            При решении алгоритма не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
            */

            Console.WriteLine("Задача Итоговой работы: " +
            "Написать программу, которая из имеющегося массива строк формирует другой массив из строк, длина которых <= 3 символа. " +
            "Первоначальный массив можно ввести с клавиатуры(наш вариант), либо задать на старте выполнения алгоритма. " +
            "При решении алгоритма не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.");

            Console.WriteLine("Введите число - размерность массива:");

            bool numberCheck = int.TryParse(Console.ReadLine(), out int incomeArray_limit);
            while (!numberCheck)
            {
                Console.WriteLine("Введено не число. Повторите ввод:");
                numberCheck = int.TryParse(Console.ReadLine(), out incomeArray_limit);
            }

            string[] incomeArray = new string[incomeArray_limit];
            bool[] OutcomeArray_Validation = new bool[incomeArray_limit];

            Console.WriteLine("Введите строковый массив из " + incomeArray_limit + " элементов (через Enter):");

            for (int i = 0; i < incomeArray_limit; i++)
            {
                incomeArray[i] = Console.ReadLine();
            }

            Console.WriteLine("\n");
        }
    }
}
