using System;

namespace MergeSort
{
    public  class Program
    {
        public static void Main(string[] args)
        {

            int[] input = { 3, 5, 1, 4, 9, 7, 21, 3, 7 };
            MergeSort(input);
            Console.WriteLine("the sorted array is");
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + " ");
            }
        }
        private static  void MergeSort(int[] input)
        {
            if (input.Length <= 1)
            {
                return;
            }
            int[] FirstHalf = new int[input.Length/2];
            int[] SecondHalf = new int[(input.Length)- FirstHalf.Length];
            for(int i = 0; i < FirstHalf.Length; i++)
            {
                FirstHalf[i] = input[i];
            }
            for (int i = FirstHalf.Length; i < input.Length; i++)
            {
                SecondHalf[i-FirstHalf.Length] = input[i];
            }
            MergeSort(FirstHalf);
            MergeSort(SecondHalf);
            MergeArray(FirstHalf, SecondHalf, input);
        }

        private static void MergeArray(int[] firstHalf, int[] secondHalf, int[] input)
        {
           int i=0,j=0,k=0;
            while(i < firstHalf.Length && j < secondHalf.Length)
            {
                if (firstHalf[i] <= secondHalf[j])
                {
                    input[k] = firstHalf[i];
                    i++;
                    k++;
                }
                else
                {
                    input[k] = secondHalf[j];
                    j++;
                    k++;
                }
            }
            while(i< firstHalf.Length)
            {
                input[k]=firstHalf[i];
                k++;
                i++;
            }
            while (j < secondHalf.Length)
            {
                input[k] = secondHalf[j];
                k++;
                j++;
            }
        }
    }
}
