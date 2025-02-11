using Classes_06_02_25;
using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа №5");
            Console.WriteLine("1-30");
            int sm = Convert.ToInt32(Console.ReadLine());

            double a, b, c, k, l, m, n, x, y, z;

            switch (sm)
            {
                case 1:
                    Console.WriteLine("Введите значение А");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение B");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение C");
                    c = Convert.ToDouble(Console.ReadLine());

                    Calculator1 calculator1 = new Calculator1(a, b, c);
                    if (calculator1.CalculateA())
                        Console.WriteLine("Только одно из чисел A и B чётное.");
                    else Console.WriteLine("Либо оба чётные, либо оба нечётные.");
                    if (calculator1.CalculateB())
                        Console.WriteLine("Каждое из чисел A, B, C кратно 3");
                    else Console.WriteLine("Хотя бы 1 из чисел A, B, C не кратно 3");
                    break;

                case 2:
                    Console.WriteLine("Введите значение N");
                    n = Convert.ToDouble(Console.ReadLine());

                    Calculator2 calculator2 = new Calculator2(n);
                    if (calculator2.CalculateA())
                        Console.WriteLine("N кратно 4 или 7");
                    else Console.WriteLine("N не кратно 4 или 7");
                    if (calculator2.CalculateB())
                        Console.WriteLine("N кратно 5 и не оканчивается 0");
                    else Console.WriteLine("N не кратно 5 или оканчивается 0");

                    break;

               case 3:
                    Console.WriteLine("Введите значение k");
                    k = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение l");
                    l = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение m");
                    m = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение n");
                    n = Convert.ToDouble(Console.ReadLine());


                    Calculator3 calculator3 = new Calculator3(k, l, m, n);
                    if (calculator3.CalculateA()) Console.WriteLine("N + M > K истинно и соблюдено условие \"если N > K, то M > L\"");
                    else Console.WriteLine("N + M > K истинно или не соблюдено условие \"если N > K, то M > L\"");
                    break;

                case 4:
                    Console.WriteLine("Введите значение N");
                    n = Convert.ToDouble(Console.ReadLine());

                    Calculator4 calculator4 = new Calculator4(n);
                    if (calculator4.CalculateA()) Console.WriteLine("N кратно 3, но не кратно 9 и соблюдено условие \"если N кратно 4, то кратно 5 и 24\"");
                    else Console.WriteLine("N не кратно 3 или кратно 9 или не соблюдено условие \"если N кратно 4, то кратно 5 и 24\"");
                    break;

                case 5:
                    Console.WriteLine("Введите значение k");
                    k = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение l");
                    l = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение m");
                    m = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение n");
                    n = Convert.ToDouble(Console.ReadLine());

                    Calculator5 calculator5 = new Calculator5(k, l, m, n);
                    if (calculator5.CalculateA()) Console.WriteLine("N > 1 или M <= L + K = 0, и соблюдено условие \"если N > 2, то M^2 > L^2\"");
                    else Console.WriteLine("N < 1 и M > L + K != 0, и не соблюдено условие \"если N > 2, то M^2 > L^2\"");
                    break;

                case 6:
                    Console.WriteLine("Введите значение");
                    a = Convert.ToDouble(Console.ReadLine());

                    Calculator6 calculator6 = new Calculator6(a);
                    if (calculator6.CalculateA() > 0) Console.WriteLine($"Плата по депозиту равна {calculator6.CalculateA()}");
                    else Console.WriteLine("Введите число от 0 до 100000");
                    break;

                case 7:
                    Console.WriteLine("Введите значение N");
                    n = Convert.ToDouble(Console.ReadLine());

                    Calculator7 calculator7 = new Calculator7(n);
                    if (calculator7.CalculateA()) Console.WriteLine("N чётное и кратно 7 и не кратно 11 и 13");
                    else Console.WriteLine("N нечётное или некратно 7 или кратно 11 или 13");
                    break;

                case 8:
                    Console.WriteLine("Введите значение N");
                    n = Convert.ToDouble(Console.ReadLine());

                    Calculator8 calculator8 = new Calculator8(n);
                    if (calculator8.CalculateA()) Console.WriteLine("N не кратно 3 и кратно 7 и 10");
                    else Console.WriteLine("N кратно 3 или не кратно 7 или 10");
                    break;

                case 9:
                    Console.WriteLine("Введите значение k");
                    k = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение l");
                    l = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение m");
                    m = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение n");
                    n = Convert.ToDouble(Console.ReadLine());

                    Calculator9 calculator9 = new Calculator9(k, l, m, n);
                    if (calculator9.CalculateA()) Console.WriteLine("K = 0 и L > M или К < 0 и 2L - 3M < M");
                    else Console.WriteLine("K != 0 или L > M или К > 0 или 2L - 3M > M");
                    break;

                case 10:
                    Console.WriteLine("Введите значение N");
                    n = Convert.ToDouble(Console.ReadLine());

                    Calculator10 calculator10 = new Calculator10(n);
                    if (calculator10.CalculateA()) Console.WriteLine("N чётное и не кратно 3 и кратно 7 или не кратно 5 и кратно 4 или кратно 8 и кратно 11");
                    else Console.WriteLine("N нечётное или кратно 3 но не кратно 7 или кратно 5 но не кратно 4 или не кратно 8 и не кратно 11");
                    break;

                case 11:
                    Console.WriteLine("Введите значение");
                    a = Convert.ToDouble(Console.ReadLine());

                    Calculator11 calculator11 = new Calculator11(a);
                    if (calculator11.CalculateA() > 0) Console.WriteLine($"Стоимость покупки равна: {calculator11.CalculateA()}");
                    else Console.WriteLine("Введите число от 4000 до 10000");
                    break;

                case 12:
                    Console.WriteLine("Введите значение k");
                    k = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение l");
                    l = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение m");
                    m = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение n");
                    n = Convert.ToDouble(Console.ReadLine());

                    Calculator12 calculator12 = new Calculator12(k, l, m, n);
                    if (calculator12.CalculateA()) Console.WriteLine("K + L + M + N > 0 и соблюдено условие при K > 0 выполняется неравенство 2 * M > L, соблюдено условие K < 0 выполняется неравенство N > 3 * L");
                    else Console.WriteLine("K + L + M + N < 0 или не соблюдено условие при K > 0 не выполняется неравенство 2 * M > L, или не соблюдено условие K < 0 не выполняется неравенство N > 3 * L");
                    break;

                case 13:
                    Console.WriteLine("Введите время разговора от 0 до 24");
                    double t = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите продолжительность разговора в минутах");
                    double dt = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите стоимость минуты разговора");
                    double s = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите день недели 1 (понедельник) - 7 (воскресенье)");
                    int d = Convert.ToInt32(Console.ReadLine());

                    Calculator13 calculator13 = new Calculator13(t, dt, s, d);
                    if (calculator13.CalculateA() > 0) Console.WriteLine($"Обащая стоимость разговора: {calculator13.CalculateA()}");
                    else Console.WriteLine("Введите число от 4000 до 10000");
                    break;

                case 14:
                    БАБАБУНДА
                    break;

                case 15:
                    Console.WriteLine("Введите оценку по математике");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите оценку по информатике");
                    b = Convert.ToDouble(Console.ReadLine());

                    Calculator14 calculator15 = new Calculator14(a, b);
                    if (calculator15.CalculateA()) Console.WriteLine("Студент получит стипендию");
                    else Console.WriteLine("Руслан");
                    break;

                case 16:
                    Console.WriteLine("Введите значение A");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение B");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение C");
                    c = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение D");
                    d = Convert.ToDouble(Console.ReadLine());

                    Calculator16 calculator16 = new Calculator16(a, b, c, d);
                    calculator16.DisplayResults16();
                    break;

                case 17:
                    Console.WriteLine("Введите значение X");
                    double x17 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение Y");
                    double y17 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение Z");
                    double z17 = Convert.ToDouble(Console.ReadLine());

                    Calculator17 calculator17 = new Calculator17(x17, y17, z17);
                    calculator17.DisplayResults17();
                    break;

                case 18:
                    a = true;
                    b = false;
                    c = false;

                    Calculator18 calculator18 = new Calculator18(a, b, c);
                    calculator18.DisplayResults18();
                    break;

                case 19:
                    a = false;
                    b = false;
                    c = true;

                    Calculator19 calculator19 = new Calculator19(a, b, c);
                    calculator19.DisplayResults19();
                    break;

                case 20:
                    Console.WriteLine("Введите значение X");
                    double x20 = Convert.ToDouble(Console.ReadLine());

                    Calculator20 calculator20 = new Calculator20(x20);
                    calculator20.DisplayResults20();
                    break;

                case 21:
                    x = false;
                    y = false;
                    z = true;

                    Calculator21 calculator21 = new Calculator21(x, y, z);
                    calculator21.DisplayResults21();
                    break;
            }
        }
    }
}