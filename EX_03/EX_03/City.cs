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
        // list of residents
        private List<Person> residents;

        //instatntiation of resident list
        public City()
        {
            residents = new List<Person>();
        }

        //how residents are put into the List
        public void AddResident(Person resident)
        {
            residents.Add(resident);
        }

        // determines the story of the person walking around the city
        public void TourResident()
        {
            Console.WriteLine("Welcome to our city! Everyone introduce yourselves");
            
            //loop for all residents in the list
            for (int i = 0; i < residents.Count(); i++)
            {
                //checks to see if resident at position I is a vampire or not
                if (residents[i].GetType() != (typeof(Vampire)))
                    residents[i].speak();
                else
                { // The else clause allows the tourist to try to escape the vampire.
                    Console.WriteLine("Something feels evil about the approaching citizen. Do you still approach (Y/N)?");
                    string yn = Console.ReadLine();
                    if (yn.Contains("n"))
                        Console.WriteLine("Good call! That guy gave me the heebie jeebies.");
                    else
                    {
                        //Capture a the former tourist's self, and add it as a new vampire to the city
                        residents.Add(Vampire.speak());
                        break; // Don't want to continue the tour!
                    }
                }
            }
		}
    }
}
