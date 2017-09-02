using System;

namespace Branching
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Please type something and press the Enter key. ");
            //string userValue;
            // userValue = Console.ReadLine();
            //Console.WriteLine("You typed: " + userValue);

            Console.WriteLine("Would you prefer what is behind door number 1, 2, or 3?");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "1")
                 // = assigns a value, == evaluates the expression as true or false
                // In this case, if userValue is true, perform below code
                // In this case, if userValue is false, ignore the below code
                message = "You won a new car!";
            else if (userValue == "2")
                // else if allows us to evaluate additional conditions
                // Compared to individual if statements this keeps everything together
                // Let's us see we're still evaluating the same types of conditions
                message = "You won a new boat!";
            else if (userValue == "3")
                message = "You won a new cat!";
            else 
                // Singular else: if no other conditions are satisfied, do this
                // "Catch all"
                message = "Sorry, we didn't understand. You lose!";
            /* Curly braces were deleted from the if and else statements. You
             * can ONLY omit curly braces when the if statement is followed by
             * a single line of code. (Works the same with them added)
             */


            Console.WriteLine(message);
            Console.ReadLine();


            // Keep editions small and tidy, testing them in between

            // Concise code helps improve readability by removing extraneous characters
            // "Refactor" repeated code to condense

            // ** Memorize the if, else if, else syntax: when to use the curly braces, 
            //     and evaluation operator (==)
        }
    }
}
