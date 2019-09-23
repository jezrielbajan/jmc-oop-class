using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGround
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate
            Hero myhero = new Hero("Victor Magtanggol", "Kain durian naay panit");
            //regular class method
            myhero.jump();
            myhero.runtalawan();
            myhero.kick();
            myhero.spawn();

            //calling a static method.
            Hero.GetGameTime();
            Hero.InitiateGameOver();

            Console.Write(myhero.heroname + " - " + myhero.Ability);


            Console.Read();
        }
    }
}
