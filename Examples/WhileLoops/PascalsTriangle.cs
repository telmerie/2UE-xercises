class PascalsTriangle{
    static void Main(){
        Console.Write("Enter the number of rows for Pascal's Triangle: ");
        int numRows = Convert.ToInt32(Console.ReadLine());

        int row = 0;
        while (row < numRows)
        {
            int coefficient = 1;
            int col = 0;
            
            while (col <= row)
            {
                // Calculate and print the coefficient
                Console.Write(coefficient + " ");

                // Update the coefficient for the next position in the row
                coefficient = coefficient * (row - col) / (col + 1);

                col++;
            }

            Console.WriteLine(); // Move to the next line for the next row
            row++;
        }
    }
}