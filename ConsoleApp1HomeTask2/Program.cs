using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1HomeTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
        }

        /// <summary>
        /// 2.	Ввести с клавиатуры номер трамвайного билета (6-значное число)
        /// и проверить является ли данный билет счастливым (если на билете 
        /// напечатано шестизначное число, и сумма первых трёх цифр равна 
        /// сумме последних трёх, то этот билет считается счастливым). 
        /// </summary>
        static void Example1()
        {
            int num = 0;
            int.TryParse(Console.ReadLine(), out num);


            if(num >= 100000 && num <= 999999)
            {
                int fnum = num / 1000;
                int lnum = num % 1000;

                int fnum1 = fnum / 100;
                int fnum2 = (fnum / 10) % 10;
                int fnum3 = fnum % 10;

                int lnum1 = lnum / 100;
                int lnum2 = (lnum / 10) % 10;
                int lnum3 = lnum % 10;

                int fsum = fnum1 + fnum2 + fnum3;
                int lsum = lnum1 + lnum2 + lnum3;

                if (fsum == lsum)
                {
                    Console.WriteLine("Lucky Ticket");
                }

                else
                {

                    Console.WriteLine("Meh");
                }

            }
            else
            {
                Console.WriteLine("Again");
            }

        }

        /// <summary>
        /// 4.	Даны целые положительные числа A и B (A < B). 
        /// Вывести все целые числа от A до B включительно; 
        /// каждое число должно выводиться на новой строке; 
        /// при этом каждое число должно выводиться количество раз, 
        /// равное его значению. Например: если А = 3, а В = 7, то 
        /// программа должна сформировать в консоли следующий вывод: 
        /// 3 3 3 
        /// 4 4 4 4 
        /// 5 5 5 5 5 
        /// 6 6 6 6 6 6 
        /// 7 7 7 7 7 7 7 

        /// </summary>
        static void Example2()
        {
            int A = 0;
            int B = 0;

            int.TryParse(Console.ReadLine(), out A);
            int.TryParse(Console.ReadLine(), out B);

            if(A < B) 
            { 
                for(int i = A; i <= B; i++)
                {
                    int c = i;
                    while(c != 0)
                    {
                        Console.Write(i+ " ");
                        c--;
                    }
                    Console.WriteLine();

                }

            }
            else {
                Console.WriteLine("A < B!!!");

                 }
        }

        /// <summary>
        /// 6.	Составить программу вывода на экран в одну строку трех 
        /// любых чисел с двумя пробелами между ними.
        /// </summary>
        static void Example3()
        {
            int a = 1, b = 2, c = 3;
            Console.WriteLine(a + "  " + b + "  " + c);
        }

        /// <summary>
        /// 7.	Вывести на экран числа 5, 10 и 21 одно под другим
        /// </summary>
        static void Example4()
        {
            Console.WriteLine("5\n10\n21");
        }
        /// <summary>
        /// 8.	Дано расстояние в сантиметрах. Найти число полных метров в нем.
        /// </summary>
        static void Example5()
        {
            int sm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sm / 100);
        }
        /// <summary>
        /// 9.	С некоторого момента прошло 234 дня. 
        /// Сколько полных недель прошло за этот период?
        /// </summary>
        static void Example6()
        {
            int w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(w / 7);
        }
        /// <summary>
        /// 10.	Дано двузначное число. Найти:
        /// a.число десятков в нем;
        /// b.число единиц в нем;
        /// c.сумму его цифр;
        /// d.произведение его цифр
        /// </summary>
        static void Example7()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if (num >= 10 || num <= 99)
            {
                int a = num / 10;
                int b = num % 10;
                int c = a + b;
                int d = a * b;
            }
            Console.WriteLine("a\nb\nc\nd");
        }
        /// <summary>
        /// 11. Вычислить значение логического выражения при следующих 
        /// значениях логических величин А, В и С:
        /// А = Истина, В = Ложь, С = Ложь:
        /// a.А или В; 
        /// b.А и В; 
        /// c.В или С.
        /// </summary>
        static void Example8()
        {
            bool A = true;
            bool B = false;
            bool C = false;
            Console.WriteLine(A || B);
            Console.WriteLine(A & B);
            Console.WriteLine(B || C);

        }
        /// <summary>
        /// 12. Даны радиус круга и сторона квадрата. 
        /// У какой фигуры площадь больше?
        /// </summary>
        static void Example9()
        {
            int R = Convert.ToInt32(Console.ReadLine());
            int A = Convert.ToInt32(Console.ReadLine());
            double Sr = Math.PI * R * R;
            double Sa = 4 * A;

            if (Sr > Sa)
            {
                Console.WriteLine("Площадь круга больше");
            }
            else if (Sr == Sa)
            {
                Console.WriteLine("Площади одинаковые");
            }
            else
            {
                Console.WriteLine("Площадб квадрата больше");
            }

        }
        /// <summary>
        /// 13.Даны объемы и массы двух тел из разных материалов. 
        /// Материал какого из тел имеет большую плотность?
        /// </summary>
        static void Example10()
        {
            int m1 = 0;
            int m2 = 0;
            int V1 = 0;
            int V2 = 0;

            int.TryParse(Console.ReadLine(), out m1);
            int.TryParse(Console.ReadLine(), out m2);
            int.TryParse(Console.ReadLine(), out V1);
            int.TryParse(Console.ReadLine(), out V2);

            double p1 = m1 / V1;
            double p2 = m2 / V2;

            if (p1 > p2)
            {
                Console.WriteLine("Материал p1 плотнее");
            }
            else
            {
                Console.WriteLine("Материал p2 плотнее");
            }
        }

        /// <summary>
        /// 15.	 Напечатать "столбиком": 
        /// a.все целые числа от 20 до 35;
        /// b.квадраты всех целых чисел от 10 до b(значение b вводится с клавиатуры; 
        /// b > 10);
        /// c.третьи степени всех целых чисел от a до 50 (значение a вводится 
        /// с клавиатуры; a< 50);
        /// d.все целые числа от a до b(значения a и b вводятся с клавиатуры; b > a).
        /// </summary>
        static void Example11()
        {
            ///a
            for (int i = 20; i <= 35; i++)
            {
                Console.WriteLine(i);
            }

            ///b
            int b = 0;
            int.TryParse(Console.ReadLine(), out b);
            for (int i = 10; i <= b; i++)
            {
                Console.WriteLine(i * i);
            }
        }

        /// <summary>
        /// 22.	Даны два целых числа. Найти: 
        /// a.их среднее арифметическое; 
        /// b.их среднее геометрическое.

        /// </summary>
        static void Example12()
        {
            int a, b;
            int.TryParse(Console.ReadLine(), out a);    
            int.TryParse(Console.ReadLine(), out b);

            double srAr = (a + b) / 2;
            double srGm = Math.Sqrt(a * b);

            Console.WriteLine("Среднее арифметическое: " + srAr);
            Console.WriteLine("Среднее геометрическое: " + srGm);

        }

        /// <summary>
        /// 24.	Составить программу обмена значениями трех переменных 
        /// величин, а, b, c по следующей схеме: 
        /// a.b присвоить значение c, а присвоить значение b, с присвоить значение, а; 
        /// b.b присвоить значение, а, с присвоить значение b, а присвоить значение с.

        /// </summary>
        static void Example13()
        {
            int a, b, c;
            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);
            int.TryParse(Console.ReadLine(), out c);
            int temp = a;
            int temp2 = b;
            int temp3 = c;

            ///a
            b = temp3;
            c = temp;
            a = temp2;

            Console.WriteLine("b = " +b + "  c = " + c + "  a = " + a);

            ///b

            c = temp2;
            b = temp;
            a = temp3;

            Console.WriteLine("b = " + b + "  c = " + c + "  a = " + a);



        }

        /// <summary>
        /// 26.	Дано четырехзначное число. Найти:
        /// a.сумму его цифр;
        /// b.произведение его цифр.
        /// </summary>
        static void Example14()
        {
            int num = 0;
            int.TryParse(Console.ReadLine(), out num);

            if (num >= 1000 & num <= 9999)
            {
                int num1 = num / 1000;
                int num2 = (num / 100) % 10;
                int num3 = (num % 100) / 10;
                int num4 = num % 10;

                Console.WriteLine(num1 + num2 + num3 + num4);
                Console.WriteLine(num1 * num2 * num3 * num4);
            }
        }

        /// <summary>
        /// 31.	Известны два расстояния: одно в километрах, другое — 
        /// в футах ( 1 фут 0,305 м ). Какое из расстояний меньше?
        /// </summary>
        static void Example15()
        {
            int km = 0;
            int ft = 0;
            int.TryParse(Console.ReadLine() , out km);
            int.TryParse(Console.ReadLine(), out ft);

            double ftkm = ft * 0.305;
            

            if(km > ftkm)
            {
                Console.WriteLine("Расстояние в фунтах меньше");
            }
            else
            {
                Console.WriteLine("Расстояние в км меньше");
            }

        }

        /// <summary>
        /// Дано двузначное число. Определить: 
        /// a.какая из его цифр больше: первая или вторая; 
        /// b.одинаковы ли его цифры.

        /// </summary>
        static void Example16()
        {
            int num = 0;
            int.TryParse(Console.ReadLine(), out num);
            
            if(num >= 10 &&  num <= 99)
            {
                int num1 = num / 10;
                int num2 = num % 10;

                if(num1 > num2)
                {
                    Console.WriteLine("Первая цифра больше");
                }
                else if(num1 < num2)
                {
                    Console.WriteLine("Вторая цифра больше");
                }
                else
                {
                    Console.WriteLine("Цифры одинаковые");
                }

            }
            else
            {
                Console.WriteLine("Try again");
            }

        }

        /// <summary>
        /// Составить программу, которая в зависимости от порядкового номера 
        /// дня недели (1, 2, ..., 7)
        /// выводит на экран его название (понедельник, вторник, ..., воскресенье).
        /// </summary>
        static void Example17()
        {
            int num;
            int.TryParse (Console.ReadLine(), out num); 

            switch (num)
            {
                case 1: 
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
                default: 
                    Console.WriteLine("Такого номера нет");
                    break;
            }

        }
        /// <summary>
        /// 35.	Составить программу, которая в зависимости от порядкового 
        /// номера дня месяца (1, 2, ..., 12) выводит на экран его название 
        /// (январь, февраль, ..., декабрь).
        /// </summary>
        static void Example18()
        {
            int num;
            int.TryParse(Console.ReadLine(), out num);

            switch (num)
            {
                case 1:
                    Console.WriteLine("Январь");
                    break;
                case 2:
                    Console.WriteLine("Февраль");
                    break;
                case 3:
                    Console.WriteLine("Март");
                    break;
                case 4:
                    Console.WriteLine("Апрель");
                    break;
                case 5:
                    Console.WriteLine("Май");
                    break;
                case 6:
                    Console.WriteLine("Июнь");
                    break;
                case 7:
                    Console.WriteLine("Июль");
                    break;
                case 8:
                    Console.WriteLine("Август");
                    break;
                case 9:
                    Console.WriteLine("Сентябрь");
                    break;
                case 10:
                    Console.WriteLine("Октябрь");
                    break;
                case 11:
                    Console.WriteLine("Ноябрь");
                    break;
                case 12:
                    Console.WriteLine("Декабрь");
                    break;
                default:
                    Console.WriteLine("Такого номера нет");
                    break;
            }
        }
        /// <summary>
        /// 36.	Составить программу, которая в зависимости от порядкового 
        /// номера дня месяца (1, 2, ..., 12) выводит на экран время года, 
        /// к которому относится этот месяц.
        /// </summary>
        static void Example19()
        {
            int num;
            int.TryParse(Console.ReadLine(), out num);

            switch (num)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Зима");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Весна");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Лето");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Осень");
                    break;
                default:
                    Console.WriteLine("Такого номера нет");
                    break;
            }
        }
        /// <summary>
        /// 30.	Даны два различных вещественных числа. Определить: 
        /// a.какое из них больше;
        /// b.какое из них меньше

        /// </summary>
        static void Example20()
        {
            double num1, num2;
            double.TryParse(Console.ReadLine(), out num1);
            double.TryParse(Console.ReadLine(), out num2);


            if (num1 > num2)
            {
                Console.WriteLine("Первое вещественное число больше");
            }
            else if (num1 < num2)
            {
                Console.WriteLine("Второе вещественное число больше");
            }
            else
            {
                Console.WriteLine("Числа равны");
            }
        }
    }
}
