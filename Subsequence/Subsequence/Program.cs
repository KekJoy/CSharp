using System;

namespace Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = new int[4] { 1, 2, 3, 4 };
            int[] secondArray = new int[10] { 1, 1, 2, 3, 4, 3, 4, 2, 3, 4 };
            arraySequences(firstArray);
        }

        public static int[][] arraySequences(int[] firstArray)
        {
            // Если необходимо задать длинну массива через консоль, то она будет равна ((d-1)*d)/2, где d(длина Fa) - кол-во эл. в массиве
            int arrayLength = ((firstArray.Length - 1) * firstArray.Length) / 2;
            int[][] sequencesOfFirstArray = new int[arrayLength][];
            int subarrayLenght = firstArray.Length;
            for (int i = 0; i < arrayLength; i++) 
            {
                    sequencesOfFirstArray[i] = new int[subarrayLenght];
                if (i < 2) subarrayLenght--;
            }
            sequencesOfFirstArray[2] = new int[3]; // Костыль

            for (int i = 0; i < arrayLength; i++)
            {
                for (int n = 0; n < sequencesOfFirstArray[i].Length; n++)
                {
                    
                }
                    

            }

            return sequencesOfFirstArray;
        }



    }
}
