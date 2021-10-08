using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class Billy : Driver
    {
        public Billy(RaceCar car) : base(car)
        {
            Name = "Billy";
            SkillLevel = 4;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}