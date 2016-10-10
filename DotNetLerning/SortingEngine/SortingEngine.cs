using System;

namespace SortingEngine
{
    class SortingEngine
    {
        static int[] Sort(params int[] numbers)
        {
            //The sorting logic
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                //Loop that in operating over the un-sorted part
                //of the array
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    //Swaping the values
                    if (numbers[i] > numbers[j])
                    {
                        int oldNumber = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = oldNumber;
                    }
                }
            }//End of the sorting logic
            return numbers;
        }

        static void PrintNumbers(params int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0}", numbers[i]);
                if (i < (numbers.Length - 1))
                {
                    Console.Write(", ");
                }
            }
        }


        static void Main()
        {
            int[] numbers = { 10, 3, 5, -1, 0, 12, 8 };
            Sort(numbers);
            PrintNumbers(numbers);
            Console.WriteLine();
        }
    }
}
