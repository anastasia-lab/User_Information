using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте.\n\nВведите данные студента:");

            Console.Write("Фамилия: ");
            string SurNameString = Console.ReadLine();

            Console.Write("Имя: ");
            string NameString = Console.ReadLine();

            Console.Write("Отчество: ");
            string MiddleNameString = Console.ReadLine();

            Console.Write("Возраст: ");
            int Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("E-maile: ");
            string EmaileString = Console.ReadLine();

            Console.Write("Баллы по программированию: ");
            double ProgrammingScore = Convert.ToDouble(Console.ReadLine());

            Console.Write("Баллы по математике: ");
            double MathScore = Convert.ToDouble(Console.ReadLine());

            Console.Write("Баллы по физике: ");
            double PhysicScore = Convert.ToDouble(Console.ReadLine());

            Console.Write($"\nСтудент {SurNameString} {NameString} {MiddleNameString} {Age} лет имеет следующие результаты:\n");

            double TotalScore = ProgrammingScore + MathScore + PhysicScore;
            Console.WriteLine($"\nОбщий балл: {TotalScore}");

            double AverageScore = TotalScore / 3;
            Console.WriteLine($"Средний балл: {AverageScore}");

            Console.WriteLine($"\nПочта для отправки результатов: {EmaileString}\n");
            Console.WriteLine("Итоговые баллы по:");
            Console.WriteLine($"Программированию: {ProgrammingScore}");
            Console.WriteLine($"Математике: {MathScore}");
            Console.WriteLine($"Физике: {PhysicScore}");

            Console.ReadKey();
        }
    }
}
