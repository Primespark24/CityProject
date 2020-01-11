using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_03
{
    class Person : Speak.ISpeak
    {
        private string name;
        // base constuctor for person
        public Person()
        {
            name = "John Doe";
        }
        // constuctor for person
        public Person(string nameInput)
        {
            name = nameInput;
        }

        public string GetName()
        {
            return name;
        }
        //speak function so other classes may use it
        public void speak() { }
    }
}
