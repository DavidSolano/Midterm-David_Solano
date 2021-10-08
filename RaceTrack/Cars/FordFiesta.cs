using System;

namespace RaceTrack.RaceTrack.Cars
{
    public class FordFiesta : RaceCar
    {
        public FordFiesta()
        {
            Name = "Ford Fiesta";
            TopSpeed = 250;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"the {Name} is ready to start the party");
            Console.WriteLine("get it?");
            Console.WriteLine("cause fiesta means party.. in spanish...");
        }

        public override void Brake()
        {
            Console.WriteLine($"{Name} struggles to stop. The party is simply too strong!");
            base.Brake();
        }
    }
}