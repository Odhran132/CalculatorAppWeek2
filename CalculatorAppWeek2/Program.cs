internal class Program
{
    
    static void Main(string[] args)
    {
        int a, b;
        int choice;
        double result = 0;
        //Console.WriteLine("Result:{0}", result);
        /*int firstnumber;
        int secondnumber;
        char op;

        Console.WriteLine("What is your first number?");
        firstnumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What is your second number?");
        secondnumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What would you like to do with these numbers (enter operator)");
        op = Convert.ToChar(Console.ReadLine());

        switch
        */



        Console.WriteLine("Enter 1st number ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1. Addition ");
            Console.WriteLine("2. Subtraction ");
            Console.WriteLine("3. Multiplication ");
            Console.WriteLine("4. Division ");
            Console.WriteLine("5. Average ");
            Console.WriteLine("6. Percentage ");
            Console.WriteLine("7. Exit ");
            Console.WriteLine("8. Select your choice (1-7): ");
            choice = Convert.ToInt32(Console.ReadLine());
           //double result;
        switch (choice)
            {
                case 1:
                    result = a + b;
                    break;
                case 2:
                    result = a - b;
                    break;
                case 3:
                    result = a * b;
                    break;
                case 4:
                    result = a / b;
                    break;
                case 5:
                    result = (a + b) / 2;
                    break;
                case 6:
                    result = (a / b) * 100;
                    break;
                case 7:
                    result = 0;
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;
            }
            Console.WriteLine("Result:{0}",result);
        //Console.ReadKey();
    


     }
}
