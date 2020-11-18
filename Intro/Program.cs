using System;

namespace Intro
{
    class Program
    {
        //GLOBAL Vars
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Program p = new Program(); 
            p.test();
            p.handleExc();

            int res = p.GreaterNumber(23, 94);
            System.Console.WriteLine(res);

            p.HomeWork();
        }

        int GreaterNumber(int num1, int num2)
        {
            //identify the bigger/greater number
            //and return it
            if(num1 > num2)
            {
                return num1;
            }
            else{
                return num2;
            }
        }



        void HomeWork()
        {
            for(int i=50; i > 34; i--)
            {
                if(i != 37 && i != 43)
                {
                    System.Console.WriteLine(i);
                }

            }
        }
        void handleExc()
        {
            try
            {
            string inputVal ="123.9918a";
            decimal price = Decimal.Parse(inputVal); //will parse string into decimal
            System.Console.WriteLine(price);
            }
            catch(Exception ex)
            {
                System.Console.WriteLine("Error: Provided price is not a number");
                System.Console.WriteLine(ex.Message);
            }
            
        }
       void test()
        {
            System.Console.WriteLine("I am a function");

            //variables types
            string name = "Joel";
            string last = "Otero";
            int age = 34;
            float distance = 34.43f; //anything else
            decimal total = 99.32m; //money
            bool found = false;
            

            // mathematical operations
            Console.WriteLine(21 + 21);
            System.Console.WriteLine(213 - 12);
            System.Console.WriteLine(32 * 2);
            System.Console.WriteLine(900 / 92);

            // if
            if(age <99)
            {
                System.Console.WriteLine(name + " you are still young!");
            }
            else{
                System.Console.WriteLine("Sorry " + name + " you are getting old");
            }

            //for loop
            //want: numbs from 0 to 10, except 3
            for(int i=0; i < 11; i++)
            {
                if(i !=3 && i != 7)
                {
                    System.Console.WriteLine(i);
                }
                
            }

        }

    }
}