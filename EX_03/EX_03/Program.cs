using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

//code belongs to Brycen Martin and Mason Caird

namespace EX_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new city
            City Gotham = new City();

            //add residents to city
            Gotham.AddResident(new Citizen("Fred Rogers"));
            Gotham.AddResident(new Citizen("Pete Tucker"));
            Gotham.AddResident(new Citizen("Anne Trefry"));
            Gotham.AddResident(new Police("Dexter Deptuy"));
            Gotham.AddResident(new Vampire("Ivan Red"));

            //Tour City
            Console.WriteLine("Would you like to tour again. Y/N");
            string cont = "y"; 
            cont = Console.ReadLine().ToLower();
            while (cont == "y")
            {
                // determines if they want to play again or not
                if (cont.Contains("y"))
                {
                    Gotham.TourResident();
                    Console.WriteLine("Do you want to tour again? Y/N");
                    cont = Console.ReadLine().ToLower();
                }
            }
        }
    }
}
