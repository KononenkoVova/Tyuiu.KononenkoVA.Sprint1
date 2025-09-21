using Tyuiu.KononenkoVA.Sprint1.Task4.V30.Lib;

namespace Tyuiu.KononenkoVA.Sprint1.Task4.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение X:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("(x + y^3)/(e^(2 - y)) = " + ds.Calculate(x,y));
        }
    }
}   