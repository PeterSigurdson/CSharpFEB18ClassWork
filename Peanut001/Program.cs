using System;

namespace Peanut001
{
    class Program
    {
        static void Main(string[] args)
        {
            // never put anything here except creating your 
            // Driver Manager class and invoking the first run method on it

            DriverManager driver = new DriverManager();
            // Good practice: Design First, Write code later
            driver.Run();

        }
    }

    class DriverManager
    {
        // the OO Principle of Encapsulation says: Make all variables PRIVATE
        private int NumberOfLionWinners = 0;
        private int NumberOfTigerWinners = 0;
        // use getters and setters to mutate/change the variables

        public void setNumberOfLionWinners(int increment)
        {
            this.NumberOfLionWinners += increment;
        }

        public void setNumberOfTigerWinners(int increment)
        {
            this.NumberOfTigerWinners += increment;
        }

        public void Run()
        {
            Lion lion1 = new Lion();
            Tiger tiger1 = new Tiger();

            // find out whether Lions or Tigers are stronger

            // create 10 Lion Objects and 10 Tiger Objects
            // marshall these objects into ARRAYS
            // Pass the Arrays to the doCompetition() method
            // 
            Competition c1 = new Competition();
            c1.DoCompetition();
        }
    }

    class Competition
    {
        public void DoCompetition()
        {
            // DoCompetition will  take 2 arrays of Lions and Tigers as Parameters
            // iterate over each DS, use IF / THEN to see which is strong
            // set number of lion winners, how tiger winners with the public method of Driver Class
        }


    }

    class Feline
    {
            String name;
            int Strength;

            // note the use of the ZERO ARGS constructor!
            public Feline()
                {
                    this.SetStrength();
                }
            public int SetStrength()
            { Random r1 = new Random();
                // use a Random Number Generator to set the Strength
                this.Strength = r1.Next()/10000000;
            Console.WriteLine(this.Strength);
                return this.Strength;
            }
    }
    class Lion:Feline
    {
      // note the colon : is how we do sub classing, inheritance in C#
    }

    class Tiger : Feline
    {
        // note the colon : is how we do sub classing, inheritance in C#
    }

}