using System;

namespace AtmService
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = 1000, pay, take;
            int select, pin = 0;
            Console.WriteLine("Enter your PIN ");
            pin = int.Parse(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("----- Welcome to Atm Service -----\n");
                Console.WriteLine("1. Current balance\n");
                Console.WriteLine("2. Withdraw cash\n");
                Console.WriteLine("3. Pay in\n");
                Console.WriteLine("4. Exit\n");
                Console.WriteLine("-----------------------------------\n\n");
                Console.WriteLine("Choose option: ");
                select = int.Parse(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        Console.WriteLine("\n Your currently balance in pounds is: {0}", amount);
                        break;
                    case 2:
                        Console.WriteLine("\n Enter the amount you want to raise ");
                        take = int.Parse(Console.ReadLine());
                        if (take < 100)
                        {
                            Console.WriteLine("\n The amount must be greater than 100...");
                        }
                        else if (take > amount)
                        {
                            Console.WriteLine("\n You can't withdraw more money than you have in your account...");
                        }
                        else
                        {
                            amount = amount - take;
                            Console.WriteLine("\n\n Pick up your money");
                            Console.WriteLine("\n Your currently balance is {0}", amount); 
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n Enter the amount you want to deposit into your account");
                        pay = int.Parse(Console.ReadLine());
                        amount = amount + pay;
                        Console.WriteLine("Your balance is {0}", amount);
                        break;
                    case 4:
                        Console.WriteLine("\n Thank you to use Atm service!");
                        break;

                };
            }
        }
    }
}
