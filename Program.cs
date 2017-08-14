using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
                       // User start program
            // Uer enters code Km to miles or miles to km
            // user types data
            // gets anwser on screen
            //end
            // 7up
           do
             {
                 Console.WriteLine("Convert Km to miles or Miles to Km");


                 Console.WriteLine("Choose convertion below");
                 Console.WriteLine("KM to Miles          Code KM");
                 Console.WriteLine("Miles to Km          Code Miles");
                 Console.WriteLine("Exit                 Code Exit");
                 string Kilometer = "KM";
                 string Miles = "Miles";
                 string Exit = "Exit";

                 string userInput = Console.ReadLine();


                 if (userInput == Kilometer)
                 {


                     Console.WriteLine("Enter KM");
                     Double KM = Double.Parse(Console.ReadLine());
                     Double Convertednumber = Math.Round(KM * 0.62137119, 2);
                     Console.WriteLine($"{Convertednumber} Milles");
                 }

                 else if (userInput == Miles)
                 {
                     Console.WriteLine("Enter Miles");
                     Double Ml = Double.Parse(Console.ReadLine());
                     Double Convertednumber = Math.Round(Ml * 1.609344, 2);
                     Console.WriteLine($"{Convertednumber} KM");
                 }

                 else if (userInput == Exit)
                 {
                     Environment.Exit(1);
                 }

                 else
                 {
                     Console.WriteLine("Error you didn't enter number or code");
                 }


                 Console.ReadLine();
             } while (KM == userInput); 

            
              
              for (int i = 1; i <= 5; i++)
              {
                Console.WriteLine("What is Your fave fruit!");
                var userInput = Console.ReadLine();
                
              } Console.WriteLine($" {i + userInput}");
            Console.ReadLine();

        }
    }
}
