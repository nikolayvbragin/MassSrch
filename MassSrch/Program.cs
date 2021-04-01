using System;

namespace MassSrch
{
    class Program
    {
        static int TryParseInput()
        {
            int OutVal;
            while (!int.TryParse(Console.ReadLine(), out OutVal))
            {
                Console.WriteLine("Введенное значение не является целым числом, повторите ввод:");
            }
            return OutVal;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива:");
            int ArrLen = TryParseInput();
            Console.WriteLine($"Заданная длина массива: {ArrLen} элемента(ов)");
            int[] MyArr = new int[ArrLen];
            Console.WriteLine("Заполнение массива");
            for (int i = 0; i < ArrLen; i++)
            {
                Console.WriteLine($"Введите элемент массива № {i + 1}");
                MyArr[i] = TryParseInput();
            }

            Console.WriteLine("Вывод содержимого массива:");
            foreach (int Val in MyArr)
            {
                Console.Write($"{Val} "); 
            }
            Console.WriteLine();
            int largestVal = 0;
            int secondLargestVal = 0;
            foreach (var Val in MyArr) if (Val > largestVal) largestVal = Val;
            Console.WriteLine($"Наибольшее значение: {largestVal}");
            foreach (var Val in MyArr)
            {
                if (Val > secondLargestVal && Val < largestVal) secondLargestVal = Val;
            }
            Console.WriteLine($"Второе наибольшее значение: {secondLargestVal}");
        }
    }
}
