using System;
namespace inheritance
{
    public class Ram: Vehicle
    { // Gas powered truck
        public double FuelCapacity { get; set; }
        public void RefuelTank() {
            FuelCapacity = 100.00;
        }
        public override void Drive(){
            Console.WriteLine($"{MainColor} Ram goes VVVRRRRUUUUUUUUUM");
        }
        public override void Turn(string direction){
            Console.WriteLine($"The Ram raced to the {direction}");
        }
        public override void Stop(){
            Console.WriteLine($"The Ram's engine is off. It doesn't have much milage...");
        }
    }
}