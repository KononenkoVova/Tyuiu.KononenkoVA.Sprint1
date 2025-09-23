using Tyuiu.KononenkoVA.Sprint1.Task6.V14.Lib;

namespace Tyuiu.KononenkoVA.Sprint1.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите строку только из строчных русских букв");
            string str = Console.ReadLine();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            bool res = ds.CheckLowerCaseRusLetters(str);

            if (res == true)
                Console.WriteLine("Cтрока составлена только из строчных русских букв. Красавчик!");
            else
                Console.WriteLine("Перечитывай условие! Cтрока составлена не только из строчных русских букв.");

        }
    }
}