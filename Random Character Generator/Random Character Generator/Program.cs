using System;
using System.Text;


/*
x - Input: Get lenght of random character (how many chars)
x - Generate random character based on lenght
x - Show random character


Fix:
- Add uppercase characters





*/






namespace randomCharGenerator
{
    class rndCharGenerator
    {
        static void Main()
        {
            Console.WriteLine("This is a random character generator!");

            // Loop through the generator again if user wants to
            bool again = true;
            while (again)
            {
                charGen();

                Console.Write("\nDo you want another random character (Y/N)? ");
                string response = Console.ReadLine();

                // Only accepts y,Y,n,N
                while (response.ToUpper() != "Y" && response.ToUpper() != "N")
                {
                    Console.WriteLine("Invalid input.");
                    Console.Write("Do you want another random number (Y/N)? ");
                    response = Console.ReadLine();
                }

                again = (response.ToUpper() == "Y");
            }

        }
        static void charGen()
        {
            int lenChar;
            // Gets the lenght of the random chars
            Console.Write("Set the lenght of the character: ");

            // Checks if lenNum is a number or > 0
            while (!int.TryParse(Console.ReadLine(), out lenChar) || lenChar == 0)
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                Console.Write("Set the lenght of the char: ");
            }


            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();
            string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            // Create random characters based on the lenght
            for (int i = 0; i < lenChar; i++)
            {
                sb.Append(characters[rnd.Next(characters.Length)]);
            }
            string rndChar = sb.ToString();
            Console.Write(rndChar);
        }
    }
}