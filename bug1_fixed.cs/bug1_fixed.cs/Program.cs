using System;

class Calculator
{
    static void Main()
    {
        //declear the variables here 
        int a, b;
        char op;
        
        
        while (true) // add while loop to ask more than one time to enter the right type input
        {
            Console.WriteLine("Enter first number: ");
            
            try // add try catch to handel the exception that may show in case the entered input not integer
            {
                a = Convert.ToInt32(Console.ReadLine()); // convert the input (string) into integer 
                break; // break the loop 
            }
            catch (Exception ex) // if an exception occured this code will run
            {
                Console.WriteLine("input must be an integer"); // print warning message for the user 
            }
        }


        //another loop of the second input
        while (true)
        {
            Console.WriteLine("Enter second number: ");
            
            try // add try catch to handel the exception that may show in case the entered input not integer
            {
                b = Convert.ToInt32(Console.ReadLine()); // convert the input (string) into integer 
                break; // break the loop 
            }
            catch (Exception ex) // if an exception occured this code will run
            {
                Console.WriteLine("input must be an integer"); // print warning message for the user 
            }
        }

        //same as the above loops 
        while (true)
        {
            try
            {
                Console.WriteLine("Choose operation (+, -, *, /): ");
                op = Convert.ToChar(Console.Read());
                break;  
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        
        
       // i did not chnage anything on the switch 
        switch(op)
        {
            case '+':
                Console.WriteLine("Result: " + (a + b));
                break;
            case '-':
                Console.WriteLine("Result: " + (a - b));
                break;
            case '*':
                Console.WriteLine("Result: " + (a * b));
                break;
            case '/':
                if(b == 0)
                    Console.WriteLine("Cannot divide by zero");
                else
                    Console.WriteLine("Result: " + (a / b));
                break;
            default:
                Console.WriteLine("Invalid operation");
                break;
        }
    }
}