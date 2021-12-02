using System;

namespace Technology
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Computer computer1 = new Computer("HP", 16, "Windows");
            Console.WriteLine(computer1.GetInfo());
            Console.WriteLine(computer1.PowerOnOff());
            Console.WriteLine(computer1.GetInfo());*/

            Laptop macbookAir = new Laptop("Apple", 8, "macOS", false);
            Console.WriteLine(macbookAir.GetInfo());
            macbookAir.UpdateMemoryAmount(8);
            macbookAir.PowerOnOff();
            Console.WriteLine(macbookAir.GetInfo());

            Smartphone iphone8 = new Smartphone("Apple", 2, "iOS", false);
            Console.WriteLine(iphone8.GetInfo());
            Console.WriteLine(iphone8.IsPhoneGood());
        }
    }
}
