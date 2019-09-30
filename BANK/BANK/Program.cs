using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = "1111", input = string.Empty;
            char ch;
            int bal = 100000;
            
            while (input != pass)
            {
                Console.WriteLine("Введите PIN-код(4 цифры): ");
                input = Console.ReadLine();
            }
            Console.WriteLine("Пароль принят");
            Console.WriteLine("Выберите операцию: (1)Остаток на счете, (2)Перевод, (3)Снятие со счета, (4)Пополнение счета, (5)Выход");
            do
            {
                ch = Console.ReadKey(true).KeyChar;
                switch (ch)
                {
                    case '1':
                        Console.WriteLine("Остаток на счете: " + bal);
                        break;
                    case '2':
                        string name;
                        Console.WriteLine("Введите имя для перевода: ");

                        if (true)
                            name = Console.ReadLine();

                        Console.WriteLine("Введите сумму для перевода: ");
                        int rep = int.Parse(Console.ReadLine());
                        int fin_bal1 = bal - rep;
                        Console.WriteLine($"Вы перевели {rep} {name}. Остаток на счете: "+ fin_bal1);                       
                        bal = fin_bal1;
                        break;
                    case '3':
                        Console.WriteLine("Введите сумму снятия: ");
                        int min = int.Parse(Console.ReadLine());
                        int fin_bal = bal - min;
                        Console.WriteLine($"Вы сняли {min}. Остаток на счете: " + fin_bal);
                        bal = fin_bal;
                        break;
                    case '4':
                        Console.WriteLine("Введите сумму пополнения: ");
                        int plus = int.Parse(Console.ReadLine());
                        int fin_bal2 = bal + plus;
                        Console.WriteLine($"Вы пополнили счет на {plus}. Остаток на счете: " + fin_bal2);
                        bal = fin_bal2;
                        break;
                    case '5':
                        Console.WriteLine("Вы уверены, что хотите выйти?(Press ENTER for EXIT)");
                        break;
                }
            } while (ch != 5);
            Console.ReadKey();

        }   


    }
}

