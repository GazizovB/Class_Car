using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\tВыберите машины, например \"1\"");
            Console.WriteLine("1. Mercedes Benz");
            Console.WriteLine("2. Hyundai");
            Console.WriteLine("3. Toyota");
            Console.WriteLine();

            int Choise1 = int.Parse(Console.ReadLine());

            //Выбор машины и отображение
            if (Choise1 == 1)
            {
                Car MercedesBenz = new Car("Mercedes Benz", new DateTime(2015, 01, 03), 12345, 432);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(MercedesBenz.ShowCar());
            }
            else if (Choise1 == 2)
            {
                Car Hyundai = new Car("Hyundai", new DateTime(2016, 12, 05), 34543, 324);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(Hyundai.ShowCar());
            }
            else if (Choise1 == 3)
            {
                Car Toyota = new Car("Toyota", new DateTime(2018, 11, 07), 34543, 410);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(Toyota.ShowCar());
            }


            Car massiv = new Car();
            int[] arr = { 2, 3, 4, 4, 4 };

            massiv.PrintArray(arr);


            Console.ReadLine();
        }
    }
}
