class CollatzConjecture{

    static void Main(){
        while(true){
            Console.Write("Enter a number for the Collatz Conjecture: ");
            int input = Convert.ToInt32(Console.ReadLine());
            
            int res = input, steps = 0;

            if(input == 0 || input == 1){
                Console.WriteLine("Goodbye");
                break;
            } 
            while(res != 1){
                steps++;
                if(res%2 == 0){
                    res /= 2;
                } else {
                    res = res * 3 + 1;
                }

                Console.WriteLine($"{steps}.value is: {res}");
            }
        }
    }
}