// class IncreasingSubsequence
// {

//     static void Main()
//     {
//         int[] inputArray = [40, 60, 90, -56, 54, 86, 100, 13];

//         int[] longestSequence = [];
//         int length = 0;

//         for (int i = 0; i < inputArray.Length && length < inputArray.Length - i; i++)
//         {

//             int[] sequence = new int[inputArray.Length];
//             sequence[0] = inputArray[i];
//             int index = 1;

//             for (int j = i + 1; j < inputArray.Length; j++)
//             {
//                 if (inputArray[j] > sequence[index - 1])
//                 {
//                     sequence[index] = inputArray[j];
//                     index++;
//                 }

//             }

//             if (index > length)
//             {
//                 longestSequence = sequence;
//                 length = index ;
//             }
//         }
    

//         for(int i = 0; i<length; i++){
//             Console.Write(longestSequence[i] + " ");
//         }


//     }

// }