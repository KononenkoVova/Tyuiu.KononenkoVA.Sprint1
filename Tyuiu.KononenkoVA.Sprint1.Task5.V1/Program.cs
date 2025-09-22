using Tyuiu.KononenkoVA.Sprint1.Task5.V1.Lib;

namespace Tyuiu.KononenkoVA.Sprint1.Task5.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Ввведите X1:");
            double x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ввведите Y1:");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ввведите X2:");
            double x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ввведите Y2:");
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            double res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}