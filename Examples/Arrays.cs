class Arrays
{

    static void Main()
    {
        //Opgave 5
        // Console.Write("Input the number of elements to be stored in the array: ");
        // int arraySize = Convert.ToInt32(Console.ReadLine());

        // int[] intArray = new int[arraySize];

        // Console.WriteLine($"Input {arraySize} elements in the array :");
        // for(int i = 0; i < intArray.Length; i++){
        //     Console.Write($"element - {i} : ");
        //     intArray[i] = Convert.ToInt32(Console.ReadLine());
        // }

        // int dublicates = 0;

        // for(int i = 0; i < intArray.Length - 1; i++){
        //     for(int j = i + 1; j < intArray.Length; j++){
        //         if(intArray[i] == intArray[j]){
        //             dublicates++;
        //             break;
        //         }
        //     }
        // }

        // Console.WriteLine("Total number of duplicate elements found in the array is : " + dublicates);

        //___________________________________________'
        //Opgave 6

        Console.Write("Input the number of elements to be stored in the array: ");
        int arraySize = Convert.ToInt32(Console.ReadLine());

        int[] intArray = new int[arraySize];

        Console.WriteLine($"Input {arraySize} elements in the array :");
        for (int i = 0; i < intArray.Length; i++)
        {
            Console.Write($"element - {i} : ");
            intArray[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("The unique elements found in the array are :");

        for (int i = 0; i < intArray.Length; i++)
        {
            for (int j = 0; j < intArray.Length; j++)
            {

                if (intArray[i] == intArray[j] && i != j)
                {
                    break;
                }

                if (j == intArray.Length - 1)
                {
                    Console.Write(intArray[i] + " ");
                }

            }

        }



    }
}