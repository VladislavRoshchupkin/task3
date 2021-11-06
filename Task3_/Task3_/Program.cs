using System;

namespace Task3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Star_system star_system = new Star_system("Solar System");
            
            Star star = new Star("Sun");
            Moon moon = new Moon("Луна");

            star_system.addPlanet(new Planet("Jupyter"));
            star_system.addPlanet(new Planet("Mars"));
            star_system.addPlanet(new Planet("Saturn"));

            Console.WriteLine("Star name: " + star.getName());
            Console.WriteLine("Star system name: " + star_system.getName());
            Console.WriteLine("Count planets: " + star_system.getPlanetList().Count);
        }
    }
}
