using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
         
            bool status = true;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            
            Console.WriteLine("ДОБРО ПОЖАЛОВАТЬ!!!");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1.Обычный: 100 HP, шанс получения урона - 50%");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("2.Танк: 150 HP, шанс получения урона - 70%");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("3.Везунчик: 50HP, шанс получения урона - 30%");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            int a = 12, b = 12;  // размер поля
            int hp = 100, damage = (a - 2) * (b - 2) / 3;
            Console.WriteLine("ВЫБЕРИТЕ ПЕРСОНАЖА");
            bool character = false;
            while (character == false)
            {
                string n = Console.ReadLine();
                int n1;
                while (!Int32.TryParse(n, out n1))
                {
                    Console.WriteLine("введено неккоректное значение");
                    Console.WriteLine("Выберите персонажа");
                    n = Console.ReadLine();
                }
                switch (n1)
                {
                    case 1: character = true; hp = hp; damage = damage / 2; break;
                    case 2: character = true; hp = hp * 3 / 2; damage = damage * 7 / 10; break;
                    case 3: character = true; hp /= 2; damage = damage * 3 / 10; break;
                    default: character = false; Console.WriteLine("ОШИБКА!!!"); break;
                }
            }
            Console.Clear();
            char[,] map1 = new char[a, b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    map1[i, j] = ' ';
                    if (i == 0)
                    {
                        map1[i, j] = '=';  //Эта и строчки ниже для определения символов границ(x)
                    }
                    if (i == (a - 1))
                    {
                        map1[i, j] = '=';
                    }
                    if (j == 0)             
                    {
                        map1[i, j] = '|'; //Границы (y)
                    }
                    if (j == (b - 1))
                    {
                        map1[i, j] = '|';
                    }
                    if (j == (b - 2) && i == (a - 2))
                    {
                        map1[i, j] = 'A'; //обозначение принцессы
                    }
                    if (j == 1 && i == 1)
                    {
                        map1[i, j] = '$'; //Обозначение героя
                    }
                    Console.Write(map1[i, j]);
                }
                Console.WriteLine();
            }
            int x = 1, y = 1;
            map1[y, x] = '$';
            while (status)
            {
                Console.WriteLine("Уровень здоровья:" + hp);
                char m = Console.ReadKey(true).KeyChar;

                switch (m)
                {
                    case 'd':
                        if (map1[y, x + 1] == '#')
                            break;
                        else
                            map1[y, x] = ' ';
                        map1[y, x + 1] = '$';
                        x++; break;
                    case 'a':
                        if (map1[y, x - 1] == '#')
                            break;
                        else
                            map1[y, x] = ' ';
                        map1[y, x - 1] = '$';
                        x--; break;
                    case 'w':
                        if (map1[y - 1, x] == '#')
                            break;
                        else
                            map1[y, x] = ' ';
                        map1[y - 1, x] = '$';
                        y--; break;
                    case 's':
                        if (map1[y + 1, x] == '#')
                            break;
                        else
                            map1[y, x] = ' ';
                        map1[y + 1, x] = '$';
                        y++; break;
                    default:
                        Console.WriteLine("Некоректное число повторите ввод"); break;
                }
                if (map1[(a - 2), (b - 2)] == '$')
                    status = false;
                Random r;
                r = new Random();
                for (int d = 2; d < damage; d++)
                {
                    int i1 = r.Next(2, (a - 1));
                    int j1 = r.Next(1, (b - 1));
                    if (y == i1 && x == j1)
                    {
                        hp = hp - 25;
                        Console.WriteLine("Ловушка!");
                    }
                }
                if (hp <= 0)
                {
                    Console.WriteLine("Вы погибли!!!"); break;
                }
                Console.Clear();
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        Console.Write(map1[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            if (hp > 0)
            {
                Console.WriteLine("ВЫ ПОБЕДИЛИ!!!");
                Console.WriteLine("Уровень здоровья:" + hp);
            }
            else
                Console.ForegroundColor = ConsoleColor.DarkRed;
            {
                Console.WriteLine("Вы погибли!!!");
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.ReadKey();
        }
    }
}
