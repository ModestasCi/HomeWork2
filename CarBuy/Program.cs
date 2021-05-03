using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuy
{
    class Program
    {
        public static void Main(string[] args)
        {
            PrintTextToConsole();
            Console.ReadLine();
        }

        public static void PrintTextToConsole()
        {
            string manufacturer = AskUserManufacturer();
            string model = AskUserModel();
            string engine = AskUserEngine();
            string color = AskUserColor();
            //string information = AskUserInformation();

            char Answer;
            //string Ans;
            //Ans = Console.ReadLine();
            //Answer = char.Parse(Ans);
            //Console.Write("Would you like to have a test drive? (y=Yes/n=No)? ");
            //Ans = Console.ReadLine();
            //Answer = char.Parse(Ans);
            //if (Answer == 'y')
            //{
            //    Console.WriteLine("\nPlease enter your phone number.");
            //    Console.WriteLine("We will get back to you when your car will be ready.\n");
            //}
            //if (Answer == 'n')
            //    Console.Write("\nPlease enter your phone number.!\n");


            //PrintUserData(manufacturer, model, engine, color, information);
            //Console.WriteLine($"manufacturer: {manufacturer}");
            //Console.WriteLine($"manufacturer: {manufacturer}, model: {model}, engine: {engine}, color: {color}, data: {information}");

        }

        public static string AskUserManufacturer()
        {
            Console.WriteLine("Please enter the desired manufacturer: \n1 - Audi \n2 - VW");
            var manufacturer = Console.ReadLine();
            if (manufacturer != "1" && manufacturer != "2")
            {
                Console.WriteLine($"\n{manufacturer} not found");
            }

            else
            {
                var manufacturerAsNumber = manufacturer.ToString();
            }
            string[] manufacturer1 = { "Audi", "VW" };
            Console.WriteLine($"Your chosena brand is: " + manufacturer);

            return Console.ReadLine();
        }

        public static string AskUserModel()
        {
            int price = 0;
            Console.WriteLine("\nPlease choose desired model: \n1 - A3 \n2 - A4");
            var model = Convert.ToString(Console.ReadLine());
            if (model != "1" && model != "2")
            {
                Console.WriteLine($"\n{model} not found");
            }
            else
            {
                var modelAsNumber = model.ToString();
            }
            string[] model1 = { "Audi", "VW" };
            Console.WriteLine($"Your chosen model is: " + model);
            price += 30000;
            return Console.ReadLine();
        }

        public static string AskUserEngine()
        {
            int price = 0;
            Console.WriteLine("please enter the desired engine type: \n1 - Petrol \n2 - Diesel ");
            var engine = Convert.ToString(Console.ReadLine());
            if (engine != "1" && engine != "2")
            {
                Console.WriteLine($"\n{engine} not found");
            }
            else
            {

                var engineAsNumber = engine.ToString();
            }
            string[] engine1 = { "Petrol", "Diesel" };
            Console.WriteLine($"Your chosen model is: " + engine);
            price += 25000;
            return Console.ReadLine();
        }

        public static string AskUserColor ()
        {
            int price = 0;
            Console.WriteLine("please enter the desired engine type: \n1 - White \n2 - Black ");
            var color = Convert.ToString(Console.ReadLine());
            if (color != "1" && color != "2")
            {
                Console.WriteLine($"\n{color} not found");
            }
            else
            {

                var colorAsNumber = color.ToString();
            }
            string[] color1 = { "White", "Black" };
            Console.WriteLine($"Your chosen color is: " + color);
            price += 5000;
            return Console.ReadLine();
        }

        public static string AskUserInformation()
        {

            Console.WriteLine("please enter your phone number and email: \n1 - Petrol \n2 - Diesel ");
            var engine = Convert.ToString(Console.ReadLine());
            if (engine != "1" && engine != "2")
            {
                Console.WriteLine($"\n{engine} not found");
            }
            else
            {

                var engineAsNumber = engine.ToString();
            }
            string[] engine1 = { "Petrol", "Diesel" };
            Console.WriteLine($"Your chosen model is: " + engine);
            return Console.ReadLine();


        }
    }
}

