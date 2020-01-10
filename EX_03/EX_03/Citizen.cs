using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_03
{
    class Citizen : Person, Speak.ISpeak
    {
        public Citizen() : base() { }
        public Citizen(string nameInput) : base(nameInput) { }

        public void speak()
        {
            Console.WriteLine("Too bad its always so boring around here");
        }
    }
}
