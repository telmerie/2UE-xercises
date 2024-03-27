class Program
{
  static void Main()
  {
    Console.Write("Input number of Fibonacci Series :");

    Fibonacci(Convert.ToInt32(Console.ReadLine()!));

  }

  static void Fibonacci(int n)
  {

    int first = 0;
    int second = 1;
    int temp;

    for (int i = 0; i < n; i++)
    {
      Console.Write(first + " ");
      temp = first + second;
      first = second; 
      second = temp; 

    }

  }

}




