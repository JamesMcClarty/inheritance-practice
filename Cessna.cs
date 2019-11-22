using System;

namespace inheritance
{
    public class Cessna : Vehicle
    { // Propellor light aircraft
        public double FuelCapacity { get; set; }
        public void RefuelTank()
        {
            FuelCapacity = 100.00;
        }
        public override void Drive(){
            Console.WriteLine($"{MainColor} Cessna goes SOI SOI SOI SOI SOI");
        }
        public override void Turn(string direction){
            Console.WriteLine($"The chopper hovers to the {direction}");
        }
        public override void Stop(){
            Console.WriteLine($"The chopper safely lands on a helipad.");
        }
    }
}