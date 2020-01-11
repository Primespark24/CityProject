using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_03
{
    class Vampire : Person, Speak.ISpeak
    {
        // base constuctor for vampire inherited from Person
        public Vampire() : base() { }

        // constuctor for vampire inherited from Person
        public Vampire(string nameInput) : base(nameInput) { }

        // speak function for vampire to determine what they say
        public static Person speak()
        {
            Console.WriteLine("I vant to suck your Blood!");
            // action of player becoming a vampire and serving a higher power
            Console.WriteLine("You have become a vampire tell me your mortal name");
            string name = Console.ReadLine();

            //trying to create new vampire using players name
            return new Vampire(name);
        }
    }
}
