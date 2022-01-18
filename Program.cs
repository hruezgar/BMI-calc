using System;

namespace erste_konsolenanwendung_net_framework
{
    class Program
    {
        static void Main()
        {
            bool continu = true;
            while (continu == true)
            {
                Console.WriteLine("Hello! Welcome to my BMI (body mass index) calculator. Lets check if you are healthy!");
                double bodyindex;

                Console.Write("Please enter your body mass in 'kg': ");
                double mass = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter your body length in 'cm': ");
                double lengthCm = Convert.ToDouble(Console.ReadLine());
                double lengthM = lengthCm / 100;

                bodyindex = mass / Math.Pow(lengthM, 2);
                Console.WriteLine("Your BMI is: " + Math.Round(bodyindex, 2) );

                switch (bodyindex)
                {
                    case double n when 0 < n && n < 18.5:
                        Console.WriteLine("Yor are underweight. Try to eat more!");
                        break;

                    case double n when 18.5 < n && n < 24.9:
                        Console.WriteLine("You have a perfect BMI in the normal range! Gratulations! Try to stay like this.");
                        break;

                    case double n when 24.9 < n && n < 29.9:
                        Console.WriteLine("You are overweight. Make a diet!");
                        break;

                    case double n when 29.9 < n:
                        Console.WriteLine("You are obese. Please go to your local doctor!");
                        break;

                    default:
                        Console.WriteLine("Pleas give me some real numbers!");
                        break;
                }
                Console.Write("Do you want to calculate again? If yes then type 'yes'. Else type'no' :");

                string read = Console.ReadLine();
                if (read == "yes")
                {

                }
                else if (read == "no")
                {
                    continu = false;
                }
                else
                {
                    Console.WriteLine("The application will continue because you entered a non given value.");
                }
            }

        }

    }
}