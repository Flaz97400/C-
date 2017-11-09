using System;
using System.IO;
using System.Net;


namespace HelloWorld
{
    class Program
    {

        private static string k = "";

        static void Main(string[] args)
        {

            /* Chapter 1
            Console.WriteLine("Hello world");
            Console.ReadLine();
             */

            /* Chapter 2
            int x = 7;
            int y = x + 3;
            Console.WriteLine(y);

            Console.WriteLine("What is your name?");

            Console.WriteLine("Type your first name:");
            string firstName = Console.ReadLine();
            
            Console.WriteLine("Type your last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Hello, " + firstName + " " + lastName);
            */

            /* Chapter 3 Part 1        
             
            Console.WriteLine("Fabien's Big Giveaway");
            Console.WriteLine("Choose a door: 1, 2 or 3 :");
            string chosenDoor = Console.ReadLine();

            string message = String.Empty;

            if (chosenDoor == "1")         
                 message = "You won a new car !";            
            else if (chosenDoor == "2")
                 message = "You won a new boat !";
            else if (chosenDoor == "3")
                 message = "You won a new cat !";
            else
            {
                 message = "Sorry we didn't understand";
                 message += " you lose.";
            }

            Console.WriteLine(message);
            */

            /* Chapter 3 Part 2
             
            Console.WriteLine("Fabien's Big Giveaway");
            Console.WriteLine("Choose a door: 1, 2 or 3 :");
            string chosenDoor = Console.ReadLine();

            string message = (chosenDoor == "1") ? "boat" : "strand of lint";
            
            //Console.Write(" You won a ");
            //Console.Write(message);
            //Console.WriteLine(".");

            Console.WriteLine("You won a {0}.", message);
            Console.WriteLine("You choose {0}, therefore you won a {1}", chosenDoor, message);
            */

            /* Chapter 4 - Operators, Expressions and statements
            

            // variable declaration
            int x, y, a, b;
            
            //Assignment operator
            x = 3;
            y = 2;
            a = 1;
            b = 0;

            // there are many mathamatical operators ....
            x = 3 + 4;
            x = 4 - 3;
            x = 10 * 5;
            x = 10 / 5;
            x = (x + y) * (a - b);

            if (x > y) // < >= <=
            {
            }

            if ((x > y) && (a > b)) // ((x > y) || (a > b))
            {

            }
             * */

            /* Chapter 5 - Iteration statement
             * 
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if ( i == 7 )
                {
                    Console.WriteLine("Found seven !");
                    break;
                }
            }
            */

            /* Chapter 6 - Understanding Array   
            //int[] numbers = new int[5];
            // numbers[0] = 4;
            // numbers[1] = 8;
            // numbers[2] = 15;
            // numbers[3] = 16;
            // numbers[4] = 23;
            int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };
            string[] names = new string[] { "Fanny", "Fabien", "Nicolas", "Audrey", "Leanne"};


            Console.WriteLine( "My array length is : " + numbers.Length );
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            string zig = "You can get what you want out of life " +
                "if you help enough other people to get what they want.";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray )
            {
                Console.Write(zigChar);
            }

            Console.WriteLine(Environment.NewLine + "test");
            
            Console.WriteLine(numbers[6]);

            Console.ReadLine();
             * */


            /* Chapter 10 - Defining and calling methods             
            HelloWorld();
           

            string firstName = EnterValue("What is your firstname?");
            string lastName = EnterValue("What is your lastname?");
            string city = EnterValue("Where do you live?");


            //string reversedFirstName = reverseString(firstName);
            //string reversedLastName = reverseString(lastName);
            //string reversedCity = reverseString(city);

            DisplayResult(
                reverseString(firstName),
               reverseString(lastName),
               reverseString(city)
            );

            DisplayResult(
                reverseString(firstName) + " " +
               reverseString(lastName) + " " +
               reverseString(city)
            );

            //Console.WriteLine("Result : {0} {1}, lives in {2}", 
            //    reversedFirstName, 
            //    reversedLastName, 
            //    city);
             *  */

            /* Chapter 11  - while

            bool displaymenu = true;
            while (displaymenu)
            {
                displaymenu = MainMenu();    
            }
            */


            /* Chapter 12 - String
             *
            //string myString = "This is my \"so-called\" life";
            //string myString = "What if i need a \nnew line?";
            //string myString = "Go to your C:\\ drive";
            //string myString = @"Go to your C:\ drive";

            //string mysString1 = String.Format("{0} = {1}", "First", "Second");
            //string mysString2 = String.Format("{0:C}", "12.45");
            //string mysString3 = String.Format("{0:N} ", "126984512355");
            //string mysString4 = String.Format("Percentage: {0:P} ", ".123");
            //string mysString5 = String.Format("Phone number {0:(###) ###-####}", "156482321562");

            string myString = "   That summer we took threes accross the board";

            string myString1 = myString.Substring(6, 14);
            string myString2 = myString.ToUpper();
            string myString3 = myString.Replace( " " , "--");
            string myString4 = myString.Remove( 6, 14);

            string myString5 = String.Format(" Length before: {0} , Length after Trim: {1}",
                myString.Length, myString.Trim().Length);

            Console.WriteLine(myString);
            Console.WriteLine(myString5);
            Console.ReadLine();
             */

            /* Chapter 14 Classes
             

            Car myCar = new Car();

            myCar.color = "blue";
            myCar.Model= "Cutlas Supreme";
            myCar.Make  = "Oldsmobile";
            myCar.Year = 1986;


            Car myOtherCar;
            myOtherCar = myCar;

            myCar.color = "blue";
            myCar.Model = "Cutlas Supreme";
            myCar.Make = "Oldsmobile";
            myCar.Year = 1986;


            //Console.WriteLine(" myCar: {0} - {1} - {2} - {3}",
            //    myCar.Make, myCar.Model, myCar.color, myCar.Year);

            //decimal myCarValue = DetermineMarketValue(myCar);
            //Console.WriteLine("Your car value is: {0:C}", myCarValue);


            Console.WriteLine("Your car value is: {0:C}", myCar.GetCarValue());
             * * 
            
            string j = "";

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(i);
                j = i.ToString();
            }*/

            // Example #2: Write one string to a text file.
            WebClient myWebClient = new WebClient();
            string reply = myWebClient.DownloadString("http://msdn.microsoft.com");
            string text = "A class is the most powerful data type in C#. Like a structure, " +
                           "a class defines the data and behavior of the data type. ";
            // WriteAllText creates a file, writes the specified string to the file,
            // and then closes the file.    You do NOT need to call Flush() or Close().
            File.WriteAllText(@"C:\Users\flht001\Documents\000 - DEV\PERSO\C#\MVA\C# Fundamentals for Absolute Beginners\HelloWorld\HelloWorld\bin\Debug\WriteText.txt", reply);



        }


        /* Chapter 7 - Defining and calling methods
        private static void HelloWorld()
        {
            Console.WriteLine("Hello world !");
        }
       
        private static string EnterValue(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        private static string reverseString( string message)
        {
            string result = string.Empty;
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);
        }

        private static void DisplayResult( 
            string reversedFirstName,
            string reversedLastName,
            string reversedcity)
        {
            Console.WriteLine("Result : {0} {1}, lives in {2}",
            reversedFirstName,
            reversedLastName,
            reversedcity);
        }

        private static void DisplayResult (string message)
        {
            Console.WriteLine(message);
        }
         *  */

        /* Chapter 8 While iteration statement
        
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Option 1");
            Console.WriteLine("2) Option 2");
            Console.WriteLine("3) exit");

            string result = Console.ReadLine();
            if (result == "1")
            {
                PrintNumber();
                return true;
            }
            else if (result == "2")
            {
                GuessingGame();
                return true;
            }
            else if (result =="3")
            {
                return false;
            }
            else
            {
                return true;
            }

        }


        private static void PrintNumber()
        {
            Console.WriteLine("Print number:");
            Console.Write("Type your number:");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;

            while(counter <= result)
            {
                Console.Write(counter + " - ");
                counter++;
            }
            Console.ReadLine();
        }

        private static void GuessingGame()
        {
            Console.WriteLine("Guessing Game:");
            Console.ReadLine();
            Random myRandom = new Random();

            int randomNumner = myRandom.Next(1, 11);
            int guesses = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10:");
                string result = Console.ReadLine();
                guesses++;
                if (result == randomNumner.ToString())
                    incorrect = false;
                else Console.WriteLine("Wrong !");       
            }
            while (incorrect);
            Console.WriteLine("Correct! it took you {0} guesses.", guesses);
            Console.ReadLine();
        }
         */

        private static decimal DetermineMarketValue ( Car car)
        {
            decimal carValue = 100.0M;
            return carValue;
        }


        class Car
        {

            public Car()
            {
                Make = "Nissan";
            }

            public Car( string make, string model, string color, int year)
            {
                Make = make;
                Model = model;
                Color = color;
                Year = year;
            }

            public string Make {get;set;}
            public string Model { get; set;}
            public int Year { get; set; }
            public string Color { get; set; }

            private int myVar;

            public int MyProperty
            {
                get { return myVar; }
                set { myVar = value; }
            }


            public decimal GetCarValue()
            {
                if (Year > 2000) return 200.0M;
                else return 100.0M;
            }
            
        }
    }
}
