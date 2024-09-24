/*
 * Classname: BankingApp
 * Information: Logical operators demo
 * Version 1
 * Author: Dr James Connolly
 * Date: August 2024
 */

//Call the BankingApp method to begin application
using System.Xml.Serialization;

BuildBankingApp();

//Functions / methods should be verbs.
// With C# Pascal Case should be used with function names starting with a capital letter.
// Function names should not have underscores.

void BuildBankingApp()
{
    int choice;
    double depositAmount;
    double withdrawelAmount;
    double accountBalance = 1000.00;

    Console.WriteLine("Please choose an option");
    Console.WriteLine("====================");
    Console.WriteLine("1 - deposit or withdraw funds");
    Console.WriteLine("2 - View current account information");
    Console.WriteLine("Please choose an option (1-2)");

    // Read choice for the main menu
    // explicitly typecast the string input
    // from the keyboard and convert to
    // an integer so we can use it within the if statements
    choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1 || choice == 2)
    {
        Console.WriteLine("Please choose an option");
        Console.WriteLine("====================");
        Console.WriteLine("1 - deposit funds");
        Console.WriteLine("2 - withdraw funds");
        Console.WriteLine("Please choose an option (1-2)");

        // Read choice for the main menu
        // explicitly typecast the string input
        // from the keyboard and convert to
        // an integer so we can use it within the if statements
        choice = Convert.ToInt32(Console.ReadLine());

        // The "==" in this loop is an example of a comparison operation
        if (choice == 1)
        {
            Console.WriteLine("How much do you want to deposite?");
            Console.WriteLine("Enter amount including pence using a decimal point");
            //typically a currency value is input as a decimal
            // value so the "double" type is required to store the
            // deposite amount. This is an example of explicit typecast
            depositAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The original balance was {0}", accountBalance);
            accountBalance += depositAmount;
            Console.WriteLine("The new balance is now {0}", accountBalance);
        }
        if (choice == 2)
        {
            Console.WriteLine("How much do you want to withdraw from account?");
            Console.WriteLine("Enter amount including pence using a decimal point");
           
            withdrawelAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The original balance was {0}", accountBalance);
            accountBalance -= withdrawelAmount;
            Console.WriteLine("The new balance is now {0}", accountBalance);
        }
    }
    else
    {
        //An invalid number has been selected. Advise the user accordingly
        Console.WriteLine("Please choose a valid menu option between 1-2");
    }
}
