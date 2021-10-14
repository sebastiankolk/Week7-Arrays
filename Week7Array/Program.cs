using System;

namespace Week7Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere tulemast väga ohutusse söögirestorani!");
            string[] menu = { "võileib juustuga ja singiga", "omlett", "puder", "keedumuna", "pannkoogid" };

            Console.WriteLine($"Meie menüüs on {menu.Length} : ");

            for (int i = 0; i < menu.Length; i++)
            {

                Console.WriteLine(menu[i]);
            }


            Console.WriteLine("Palun valige mida te soovite hommikusöögiks soovite süüa. (sisesta number 1-5)");
            int userchoice = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine($"oled valinud {menu[userchoice]}");
        }
    }
}
