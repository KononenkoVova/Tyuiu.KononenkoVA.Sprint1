using Tyuiu.KononenkoVA.Sprint1.Task7.V17.Lib;

namespace Tyuiu.KononenkoVA.Sprint1.Task7.V17
{
    class Program
    {
        static void Main(string[] args) 
        { 
            DataService ds = new DataService();
        
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("    1 + sin(sqrt(x^2+1))");
            Console.WriteLine("z = --------------------");
            Console.WriteLine("        cos(12*y-4)     ");

            double x, y;

            Console.WriteLine("Введите значение X:");
            x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            y = double.Parse(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine(ds.Calculate(x,y));
            Console.ReadKey();


        }  

    
    }

}