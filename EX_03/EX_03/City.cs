using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EX_03
{
    class City
    {
        private List<Person> residents;

        public City()
        {
            residents = new List<Person>();
        }

        public void AddResident(Person resident)
        {
            residents.Add(resident);
        }

        public void TourResident()
        {
            Console.WriteLine("Welcome to our city! Everyone introduce yourselves");
            for (int i = 0; i < residents.Count(); i++)
            {
                if (residents[i].GetType() != (typeof(Vampire))) // Change this so that the if clause handles non-vampires.
                    residents[i].speak();
                else
                { // The else clause allows the tourist to try to escape the vampire.
                    Console.WriteLine("Something feels evil about the approaching citizen. Do you still approach (Y/N)?");
                    string yn = Console.ReadLine();
                    if (yn.Contains("n"))
                        Console.WriteLine("Good call! That guy gave me the heebie jeebies.");
                    else
                    {
                        //Capture a pointer to the former tourist's self, and add it as a new vampire to the city
                        residents.Add(Vampire.speak());
                        break; // Don't want to continue the tour!
                    }
                }
            }
		}
    }
}
