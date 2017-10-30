using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hype
{
    class Program
    {
        static void Main(string[] args)
        {
            char again = 'д';
            while (again == 'д')
            {
                double x;
                double y;
                double total;
                char oper;

                Console.WriteLine("Введите первое число:");
                x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите оператор:");
                oper = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Введите второе число:");
                y = Convert.ToDouble(Console.ReadLine());

                if (oper == '+')
                {
                    total = x + y;
                    Console.WriteLine("Cумма " + x + " и " + y + " равна " + total + ".");
                }

                else if (oper == '-')
                {
                    total = x - y;
                    Console.WriteLine("Разность " + x + " и " + y + " равна " + total + ".");
                }

                else if (oper == '*')
                {
                    total = x * y;
                    Console.WriteLine("Умножение " + x + " на " + y + " равно " + total + ".");
                }

                else if (oper == '/')
                {
                    total = x / y;
                    Console.WriteLine("Деление " + x + " на " + y + " равно " + total + ".");
                }
                else
                {
                    Console.WriteLine("Неизвестный оператор.");
                }
                Console.WriteLine("Вы хотите продолжить работу с калькулятором? (д/н)");
                again = Convert.ToChar(Console.ReadLine());

            }
            
        }
    }
}
