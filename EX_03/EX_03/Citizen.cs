using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_03
{
    class Citizen : Person, Speak.ISpeak
    {
        // base constuctor for Citizen inherited from Person
        public Citizen() : base() { }

        // constuctor for Citizen inherited from Person
        public Citizen(string nameInput) : base(nameInput) { }

        //citizens way of speaking to players
        public void speak()
        {
            Console.WriteLine("Too bad its always so boring around here");
        }
    }
}
