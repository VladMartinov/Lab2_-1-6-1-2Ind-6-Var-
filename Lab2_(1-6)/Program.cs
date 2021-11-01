using System;

namespace Lab2__1_6_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания (7 - это 1 индивидуальное,8 - это 2 индивидуальное (Вариант 6) )");
            int N = int.Parse(Console.ReadLine());           
                switch (N)
                {
                    case 1:
                    {
                        Console.WriteLine("Задание №1");
                        Console.WriteLine("Введите значение переменной a, b и c для решения квадратного уравнения ax^2+bx+c=0");
                            double a;
                            Console.WriteLine("Значение числа a");
                            a = double.Parse(Console.ReadLine());
                            double b;
                            Console.WriteLine("Значение числа b");
                            b = double.Parse(Console.ReadLine());
                            double c;
                            Console.WriteLine("Значение числа c");
                            c = double.Parse(Console.ReadLine());
                            double D;
                            D = (b * b) - 4 * (a * c);
                            Console.WriteLine("Дискрименант равен = " + D);
                            if (D < 0)
                            {
                                Console.WriteLine("Дискрименант отрицательный - Корней нету");
                            }
                            else
                            {
                                if (D > 0)
                                {
                                    double x1, x2;
                                    x1 = (-b + Math.Sqrt(D)) / 2 * a;
                                    x2 = (-b - Math.Sqrt(D)) / 2 * a;
                                    Console.WriteLine("Решение имеет 2а Корня");
                                    Console.WriteLine("1й Корнь = " + x1);
                                    Console.WriteLine("2й Корнь = " + x2);
                                }
                                else
                                {
                                    double x;
                                    x = (-b) / 2 * a;
                                    Console.WriteLine("Решение имеет 1н Корень");
                                    Console.WriteLine($"Корень {x}+yi ");
                                    Console.WriteLine($"Корень {x}-yi ");

                                }
                            }
                            break;
                        }
                    case 2:
                    {
                        Console.WriteLine("Задание №2");
                        double pi4 = 1, num = 3;
                            Console.WriteLine("Введите количесво членов ряда");
                            int kol = int.Parse(Console.ReadLine());
                            for (int i = 0; i < kol; i++)
                            {
                                if (i % 2 != 0)
                                {
                                    pi4 += 1 / num;
                                }
                                else
                                {
                                    pi4 -= 1 / num;
                                }
                                num += 2;
                            }
                            pi4 = 4 * pi4;
                            Console.WriteLine($"Ответ: {pi4}");
                            break;
                        }
                    case 3:
                    {
                        Console.WriteLine("Задание №3");
                        Console.WriteLine("Введите число элементов для ряда Фибоначчи");
                            int n = int.Parse(Console.ReadLine());
                            int num = 0;
                            int n0 = 1, n1 = 1, n2;
                            Console.WriteLine(n0 + "");
                            Console.WriteLine(n1 + "");
                            for (int i = 0; i < n; i++)
                            {
                                n2 = n0 + n1;
                                double n_2 = n2 / 1000;
                                if (n_2 >= 1 && n_2 < 10)
                                {
                                    num++;
                                }
                                Console.WriteLine(n2 + "");
                                n0 = n1;
                                n1 = n2;
                            }
                            Console.WriteLine("");
                            Console.WriteLine("Количесво 4х значных чисел :" + num);
                            break;
                        }
                    case 4:
                    {
                        Console.WriteLine("Задание №4");
                        double x, s, c, q;
                            int i, fakt, z;
                            Console.WriteLine("Введите x: ");
                            x = double.Parse(Console.ReadLine());
                            Console.WriteLine("Введите  q: ");
                            q = double.Parse(Console.ReadLine());
                            s = x * x;
                            fakt = 2;
                            c = 1;
                            i = 2;
                            z = -1;
                            while (s / fakt >= q)
                            {
                                c = c + z * s / fakt;
                                i += 2;
                                s = s * x * x;
                                fakt = fakt * (i - 1) * i;
                                z = z * (-1);
                            }
                            i = i / 2 + 1;
                            x = Math.Cos(x);
                            Console.WriteLine($"Количество слагаемых =  {i}");
                            Console.WriteLine("Значение cos(x) = " + c);
                            Console.ReadKey();
                            break;
                        }
                    case 5:
                    {
                        Console.WriteLine("Задание №5");
                        Console.WriteLine("Введите число:");
                            int n = int.Parse(Console.ReadLine());
                            int p = 0;

                        for (int i = 10; i < 1000; i++)
                            {
                          
                                double x3, y3, z3;
                                int x = i % 10;
                                int y = (i % 100) / 10;
                                int z = i / 100;
                                if (i > 99)
                                {
                                    x3 = Math.Pow(x, 3);
                                    y3 = Math.Pow(y, 3);
                                    z3 = Math.Pow(z, 3);
                                if (x3 + y3 + z3 == n)
                                    p++;
                                break;
                                
                                }
                                
                          
                            }
                     if (p==0)
                        { Console.WriteLine("Решений нету"); }
                     else { Console.WriteLine("Решение есть"); }
                            break;
                        }
                    case 6:
                    {
                        Console.WriteLine("Задание №6");
                        Console.WriteLine("Введите ваш возраст");

                            int age = int.Parse(Console.ReadLine());


                            int numm = age % 10;
                            if (numm == 1)
                            {
                                Console.WriteLine($"Вам: {age} Год");
                            }
                            else if (numm < 5 && numm > 1)
                            {
                                Console.WriteLine($"Вам: {age} Года");
                            }
                            else
                            {
                                Console.WriteLine($"Вам: {age} Лет");
                            }



                            break;
                        }
                    case 7:
                    {
                        Console.WriteLine("Задание №1(Индивидуальное(Вариант 6))");
                        double a, b, c, res;
                            Console.WriteLine("Введите Число a,b и c");
                            Console.WriteLine("Число a");
                            a = double.Parse(Console.ReadLine());
                            Console.WriteLine("Число b");
                            b = double.Parse(Console.ReadLine());
                            Console.WriteLine("Число c");
                            c = double.Parse(Console.ReadLine());
                            if (a < b || a < c)
                            {
                                if (b < c)
                                {
                                    res = a * b;
                                }
                                else
                                {
                                    res = a * c;
                                }
                            }
                            else
                            {
                                res = c * b;
                            }

                            Console.WriteLine("Произведение наименьших чисел: " + res);

                            break;
                        }
                    case 8:
                    {
                        Console.WriteLine("Задание №2(Индивидуальное(Вариант 6))");
                        Console.WriteLine("\ny/x |   2\t3\t4\t5");
                            Console.Write("----------------------------------");
                            Console.WriteLine();
                            for (int i = 2; i < 6; i++)
                            {
                                Console.Write(i + "   |  ");
                                for (int j = 2; j < 6; j++)
                                {
                                    Console.Write("\t" + i * j);
                                }
                                Console.WriteLine("");
                                Console.WriteLine("");
                            }
                            Console.ReadLine();
                            break;
                        }
                    default:
                        Console.WriteLine("Введен некорректный номер");
                        break;

                }
           
            
        }
    }
}
