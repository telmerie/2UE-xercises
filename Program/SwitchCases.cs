class SwitchCases
{

    public void Exercise11()
    {
        
        // float a = 1, b = 5, c = 7; // d = -1
        // float a = 2, b = 6, c = 4; // d = 2
        float a = 2, b = 0, c = 0; // d = 1

        float d = b * b - 4 * a * c;

        double root, x1 = 0, x2 = 0;

        switch (d)
        {
            case > 0:
                root = 2;
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                break;
            case 0:
                root = 1;
                x1 = -b / (2 * a);
                break;
            default:
                root = -1;
                break;
        }

        switch (root)
        {
            case 2:
                Console.WriteLine("The equation has 2 solutions");
                Console.WriteLine($"x = {x1} v x = {x2}");
                break;
            case 1:
                Console.WriteLine("The equation has 1 solution");
                Console.WriteLine($"x = {x1}");
                break;
            default: 
                Console.WriteLine("Root are imaginary;\nNo Solution.");
                break; 

        }

    }

}