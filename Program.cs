using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Making new classees
            Cessna cessna = new Cessna();
            Ram ram = new Ram();
            Tesla tesla = new Tesla();
            Zero zero = new Zero();

            cessna.MainColor = "Black";
            ram.MainColor = "White";
            tesla.MainColor = "Blue";
            zero.MainColor = "Red";

            cessna.Drive();
            cessna.Turn("west");
            cessna.Stop();

            ram.Drive();
            ram.Turn("east");
            ram.Stop();

            tesla.Drive();
            tesla.Turn("right");
            tesla.Stop();

            zero.Drive();
            zero.Turn("left");
            zero.Stop();
        }
    }
}
