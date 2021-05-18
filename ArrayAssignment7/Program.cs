using System;

namespace ArrayAssignment7
{

    public enum Order
    {
        Ascending = 0,
        Descending = 1,
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] array=InitializationOfArray();
            if (array != null)
            {
                TheIndexOfMinAndMax(array);
                ArrangeTheArrayAsscendingly(array, Order.Ascending);
                SubArray(array);

                Console.Write("Please enter a number representing the starting point of the new subarray: ");
                string inputIndex = Console.ReadLine();

                Console.Write("Please enter a number representing the starting point of the new subarray: ");
                string inputLength = Console.ReadLine();
                if (int.TryParse(inputIndex, out int index) && int.TryParse(inputLength, out int length))
                {
                    SimilarToSubstring(index, length, array);
                }


            }
          
        }

        private static int[] InitializationOfArray()
        {
            Console.Write("Please enter a number representing the length of the array:");
            string input = Console.ReadLine();

            if(int.TryParse(input, out int nr))
            {
                int[] array = new int[nr];

                for (int i = 0; i < nr; i++)
                {
                    Console.Write("Please write a number:");
                    if(int.TryParse(Console.ReadLine(), out int element))
                    {
                        array[i] = element;
                    }
                    
                }


                Console.Write("The array is: ");
                for(int j = 0; j < array.Length; j++)
                {
                    if (j == array.Length - 1)
                    {
                        Console.Write($"{array[j]}");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write($"{array[j]}, ");
                    }
                    
                }
                return array;
            }
            else
            {
                return null;
            }
        }

        private static void TheIndexOfMinAndMax(int[] array)
        {
            int min = array[0];
            int indexOfMin = 0;

            int max = array[0];
            int indexOfMax = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i]<min)
                {
                    min = array[i];
                    indexOfMin = i;
                }

                if (array[i] > max)
                {
                    max = array[i];
                    indexOfMax = i;
                }
            }
            Console.WriteLine($"The index of the minimum value is {indexOfMin}");
            Console.WriteLine($"The index of the maximum value is {indexOfMax}");
        }

        private static void SubArray(int[] array)
        {
            int even = 0;
            int odd = 0;

            int i = 0;
            int j = 0;

            foreach(var elem in array)
            {
                if (elem % 2 == 0)
                {
                    even++;
                    i++;
                }
                else
                {
                    odd++;
                    j++;
                }
            }

            int[] oddArray = new int[odd];
            int[] evenArray = new int[even];
            j = 0;
            i = 0;

            foreach (int elem in array)
            {
                if (elem % 2 == 0)
                {
                    evenArray[i] = elem;
                    i++;
                }
                else
                {
                    oddArray[i] = elem;
                    j++;
                }
            }

            Console.Write("The even sub array is: ");
            foreach(var element in evenArray)
            {

                Console.Write($"{element}, ");
            }

            Console.WriteLine();

            Console.Write("The odd sub array is: ");
            foreach (var element in oddArray)
            {
                Console.Write($"{element}, ");
            }

            Console.WriteLine();
        }

        private static void ArrangeTheArrayAsscendingly(int[] array, Order order)
        {
            Console.Write($"The {order} sorted array is: ");

            if (string.Equals(order.ToString(), Enum.GetName(typeof(Order), Order.Ascending)))
            {
                Array.Sort(array);
                foreach(var element in array)
                {
                    Console.Write($"{element}, ");
                }
            }
            else
            {
                Array.Reverse(array);
                foreach (var element in array)
                {
                    Console.Write($"{element}, ");
                }
            }

            Console.WriteLine();
              
            //?????????????????????????????????????????????????????????????????
            //int min = 0;
            //int intermediary = array[0];
            //int[] arrangedArray = new int[array.Length];
            //int i = 0;

            //if(string.Equals(order.ToString(), Enum.GetName(typeof(Order), Order.Descending)))
            //{
            //    foreach(var element in array)
            //    {
            //        if (element < intermediary)
            //        {
            //            arrangedArray[i] = intermediary;
            //            intermediary = element;
            //            i++;
            //        }
            //        else
            //        {

            //        }
            //    }

            //}
            //else 
            //{

            //}

        }

        private static void SimilarToSubstring(int index, int length, int[] array)
        {
            int[] subArray = new int[length];

            for (int i = index, j = 0; j < length; i++, j++)
            {
                subArray[j] = array[i];
            }


            //int i = index;
            //int j = 0;

            //do
            //{
            //    subArray[j] = array[i];
            //    i++;
            //    j++;
            //} while (j < length);


            Console.Write($"The subarray starting from index {index} and having a length of {length} is: ");
            foreach(var elem in subArray)
            {
                Console.Write($"{elem}, ");
            }
            Console.WriteLine();
        }
    }
}
