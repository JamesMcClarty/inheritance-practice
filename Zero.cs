using System;
namespace inheritance
{
    public class Zero : Vehicle
    { // Electric motorcycle
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {
            BatteryKWh = 100.00;
        }
        public override void Drive(){
            Console.WriteLine($"{MainColor} Motorcycle screams YEEEEEEEEEOOOOOW");
        }
        public override void Turn(string direction){
            Console.WriteLine($"The bike banks to the {direction}");
        }
        public override void Stop(){
            Console.WriteLine($"The Zero engine is off and the spoke is down.");
        }
    }
}
