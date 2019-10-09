using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double year;
            double color;
            double symbol;
            string stringColor;
            string stringSymbol;
            char pol = 'm';
            stringColor = "";
            stringSymbol = "";

            while (true)
            {
                Console.Write("Введите год: ");

                bool convertResult = Double.TryParse(Console.ReadLine(), out year);

                if (convertResult)
                    break;

                Console.WriteLine("Год не соответствует условию");
            }

            year -= 1924;
            year = Math.Abs(year);
            color = year % 5;

            symbol = year % 12;

            switch (symbol)
            {
                case 1:
                    stringSymbol = "коровы";
                    pol = 'w';
                    break;
                case 2:
                    stringSymbol = "тигра";
                    pol = 'm';
                    break;
                case 3:
                    stringSymbol = "зайца";
                    pol = 'm';
                    break;
                case 4:
                    stringSymbol = "дракона";
                    pol = 'm';
                    break;
                case 5:
                    stringSymbol = "змеи";
                    pol = 'w';
                    break;
                case 6:
                    stringSymbol = "лошади";
                    pol = 'w';
                    break;
                case 7:
                    stringSymbol = "овцы";
                    pol = 'w';
                    break;
                case 8:
                    stringSymbol = "обезьяны";
                    pol = 'w';
                    break;
                case 9:
                    stringSymbol = "курицы";
                    pol = 'w';
                    break;
                case 10:
                    stringSymbol = "собаки";
                    pol = 'w';
                    break;
                case 11:
                    stringSymbol = "свиньи";
                    pol = 'w';
                    break;
                case 0:
                    stringSymbol = "крысы";
                    pol = 'w';
                    break;
            }

            switch (color)
            {
                case 0:
                    if (pol == 'm')
                        stringColor = "Зелёного ";
                    else
                        stringColor = "Зелёной ";
                    break;
                case 1:
                    if (pol == 'm')
                        stringColor = "Красного ";
                    else
                        stringColor = "Красной ";
                    break;
                case 2:
                    if (pol == 'm')
                        stringColor = "Жёлтого ";
                    else
                        stringColor = "Жёлтой ";
                    break;
                case 3:
                    if (pol == 'm')
                        stringColor = "Белого ";
                    else
                        stringColor = "Белой ";
                    break;
                case 4:
                    if (pol == 'm')
                        stringColor = "Чёрного ";
                    else
                        stringColor = "Чёрной ";
                    break;
            }

            Console.WriteLine("Это год {0}{1}", stringColor, stringSymbol);
        }
    }
}

