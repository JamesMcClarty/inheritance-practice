using System;

namespace inheritance
{
    public class Tesla : Vehicle
    { // Electric car
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {
            BatteryKWh = 100.00;
        }
        public override void Drive()
        {
            Console.WriteLine($"{MainColor} Tesla buzzes MMMMmmmmmmmmmm!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Tesla gently turns to the {direction}");
        }
        public override void Stop()
        {
            Console.WriteLine($"The Tesla stopped for you to show what you are doing for the environment.");
        }
    }
}