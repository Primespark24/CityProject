using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_03
{
    class Vampire : Person, Speak.ISpeak
    {
        public Vampire() : base() { }
        public Vampire(string nameInput) : base(nameInput) { }

        public static Person speak()
        {
            Console.WriteLine("I vant to suck your Blood!");
            Console.WriteLine("You have become a vampire tell me your mortal name");
            string name = Console.ReadLine();

            //trying to create new vampire
            return new Vampire(name);
        }
    }
}
