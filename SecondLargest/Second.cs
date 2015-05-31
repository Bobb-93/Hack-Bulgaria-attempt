using System;

namespace SecondLargest
{
    class Second
    {
        static void second_largest(int[] arr)
        {
            int? largest=null;
            int? secondLargest=null;
            bool noSecondLargest=false;

            if(arr.Length<2)
            {
                noSecondLargest = true;
            }
            else if(arr[0]>arr[1])
            {
                largest = arr[0];
                secondLargest = arr[1];
            }
            else if(arr[0]<arr[1])
            {
                largest = arr[1];
                secondLargest = arr[0];
            }

            for(int i=2;i<arr.Length;i++) 
            {
                if (arr[i] > secondLargest)
                {
                    if (arr[i] > largest)
                    {
                        secondLargest = largest;
                        largest = arr[i];
                    }
                    else
                    {
                        secondLargest = arr[i];
                    }
                }
            }

            if(secondLargest==null)
            {
                noSecondLargest = true;
            }
            if (noSecondLargest == true)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine(secondLargest);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] ourArray = new int[n];
            Console.WriteLine("Enter the array:");

            for (int i = 0; i < n; i++)
            {
                ourArray[i] = int.Parse(Console.ReadLine());
            }
            second_largest(ourArray);
            
        }
    }
}
