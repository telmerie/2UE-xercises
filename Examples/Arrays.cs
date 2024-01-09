class Arrays
{

    static void Main()
    {
        int[] numbers = new int[10];


        for(int i = 0; i < numbers.Length; i++){
            numbers[i] = i;
        }

        for(int i = 0; i < numbers.Length; i++){
            Console.WriteLine(numbers[i]);
        }
    }
}