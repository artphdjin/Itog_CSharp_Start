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

            const int limitLength = 3;

            Console.WriteLine("Задача Итоговой работы: " +
            "Написать программу, которая из имеющегося массива строк формирует другой массив из строк, длина которых <= " + limitLength  + " символа. " +
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
            int OutcomeArray_limit = 0;

            Console.WriteLine("Введите строковый массив из " + incomeArray_limit + " элементов (через Enter):");

            for (int i = 0; i < incomeArray_limit; i++)
            {
                incomeArray[i] = Console.ReadLine();
                // Console.WriteLine(incomeArray[i] + " - " + incomeArray[i].Length); // контроль.
                if (incomeArray[i].Length <= limitLength)
                {
                    OutcomeArray_Validation[i] = true;
                    OutcomeArray_limit++;
                }
                else
                    OutcomeArray_Validation[i] = false;
            }

            if (OutcomeArray_limit > 0)
            {

                string[] OutcomeArray = new string[OutcomeArray_limit];
                int idx = 0;

                for (int i = 0; i < incomeArray_limit; i++)
                {
                    if (OutcomeArray_Validation[i])
                    {
                        OutcomeArray[idx] = incomeArray[i];
                        Console.WriteLine(OutcomeArray[idx]);
                        idx++;
                    }
                }
            }
            else
                Console.WriteLine("В заданном массиве все строки длиной больше " + limitLength);

            Console.WriteLine("\n");
        }
    }
}
