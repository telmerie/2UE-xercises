class Program
{
  static void Main()
  {
      SwitchCases switchCases = new SwitchCases();
      switchCases.Exercise11();
    

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




