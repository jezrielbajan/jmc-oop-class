using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TestingGround
{
    //Constructor Demo
    class Hero
    {
        //constructor.
        public Hero()
        {
            Console.Write("This class has been invoked.. \n");
            Console.Write("the hero has been instantiated.. \n");
        }

        //overloading Constructor
        public Hero(string HeroName)
        {
            Console.WriteLine("The Hero name is {0} ", HeroName);
        }

        public Hero(string HeroName, string Ability)
        {
            this.heroname = HeroName;
            this.Ability = Ability;
        }

        public string heroname { get; set; }
        public string Ability { get; set; }
        public int HeroLevel { get; set; }
        public int GemPoints { get; set; }

        //Class Method
        public void spawn()
        {
            //the hero will spawn
        }

        public void kick()
        {

        }

        public void kick(string kickstyle)
        {

        }

        public double getLifePoints()
        {
            return 99.9;
        }

        public void runtalawan()
        {

        }
        
        public void jump()
        {

        }

        //Static Method
        public static void InitiateGameOver()
        {

        }

        public static int GetGameTime()
        {
            return 8;
        }

        

    }
}
