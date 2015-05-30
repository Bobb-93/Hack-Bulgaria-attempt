using System;

class Program
{
    static int profit_and_loss(int[] arr1,int[] arr2)
    {
        int income = 0;
        int outcome = 0;
        for (int i = 0; i < arr1.Length; i++)
        {
            income += arr1[i];
        }

        for (int i = 0; i < arr2.Length; i++)
        {
            outcome += arr2[i];
        }

        return income-outcome;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the length of the first array: ");
        int n = int.Parse(Console.ReadLine());
        int[] profitArray=new int[n];
        Console.WriteLine("Enter the first array:");
        for(int i = 0;i<n;i++)
        {
	        profitArray[i]= int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the length of the second array: ");
        int k = int.Parse(Console.ReadLine());
        int[] lossArray=new int[3];
        Console.WriteLine("Enter the second array:");
        for(int i = 0;i<k;i++)
        {
	        lossArray[i]= int.Parse(Console.ReadLine());
        }

        int result=profit_and_loss(profitArray, lossArray);
        Console.WriteLine(result);
    }
}

