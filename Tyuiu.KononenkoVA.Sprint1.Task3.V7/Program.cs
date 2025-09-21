using Tyuiu.KononenkoVA.Sprint1.Task3.V7.Lib;

namespace Tyuiu.KononenkoVA.Sprint1.Task3.V7 
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите расстояние в верстах");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine(a + " верст – это " + ds.VerstsToKilometers(a) + " км.");
        }
    }
}