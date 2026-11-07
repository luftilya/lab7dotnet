using System.Runtime.Serialization;
using wonderful_tools;
using Point = wonderful_tools.Point;

namespace lab7;

internal static class Program
{
    static Point SetPoint(out Point p)
    {
        Console.Write("^ Введите значение x: ");

        string? x_input = Console.ReadLine();

        Console.Write("^ Введите значение y: ");

        string? y_input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(x_input) && string.IsNullOrWhiteSpace(y_input))
            return p = new Point();
        else if (string.IsNullOrWhiteSpace(y_input))
            if (double.TryParse(x_input, out double init_x))
                return p = new Point(init_x, null);
            else
                return p = new Point();
        else if (string.IsNullOrWhiteSpace(x_input))
            if (double.TryParse(y_input, out double init_y))
                return p = new Point(null, init_y);
            else
                return p = new Point();
        else
            if (double.TryParse(x_input, out double init_x) && double.TryParse(y_input, out double init_y))
                return p = new Point(init_x, init_y);
            else if (double.TryParse(y_input, out init_y))
                return p = new Point(null, init_y);
            else if (double.TryParse(x_input, out init_x))
                return p = new Point(init_x, null);
            else
                return p = new Point();
    }

    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("^ Лабораторная работа №7. Выполнили Илья Зеленев и Станислав Сахаров, бТИИ-251, вариант 1  ^");
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine("^ 1) Функция вычисления количества строк двумерного массива,     ^ 7) Windows Forms        ^" +
                            "\n^ в которых среднее арифметическое элементов меньше нуля.        ^                         ^");
            Console.WriteLine("^ 2) Составить программу, содержащую функцию вычисления значений ^ 8) Windows Forms        ^" +
                            "\n^ выражений по заданным формулам (из 1 л.р.).                    ^                         ^");
            Console.WriteLine("^ 3) Составить программу, содержащую функцию для нахождения      ^ 9) Windows Forms        ^" +
                            "\n^ суммы элементов одномерного массива А длины N.                 ^                         ^");
            Console.WriteLine("^ 4) Вычислить u, v, k.                                          ^ 10) Windows Forms       ^");
            Console.WriteLine("^ 5) Проверить, лежат ли точки в одной плоскости.                ^ 11) Windows Forms       ^");
            Console.WriteLine("^ 6) Найти площадь треугольника и периметр.                      ^ 12) Windows Forms       ^");
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.Write("^ Введите цифру задания: ");

            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                continue;

            switch (input)
            {
                case "1":
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("^ Функция вычисления количества строк двумерного массива, ^" +
                                            "\n^ в которых среднее арифметическое элементов меньше нуля. ^");
                            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                            Console.Write("^ Введите кол-во строк для заполнения: ");

                            input = Console.ReadLine();

                            if (!int.TryParse(input, out int N))
                                break;

                            Console.Write("^ Введите длину строки для заполнения: ");

                            input = Console.ReadLine();

                            if (!int.TryParse(input, out int J))
                                break;

                            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");

                            double[,] nums = new double[N, J];

                            for (int i = 0; i < N; i++)
                            {
                                Console.WriteLine($"^-ЗАПОЛНЕНИЕ-{i + 1}-СТРОКИ-^");

                                for (int j = 0; j < J; j++)
                                {
                                    Console.Write($"^ Введите значение элемента №{j + 1}: ");

                                    input = Console.ReadLine();

                                    if (!double.TryParse(input, out double d))
                                        continue;

                                    nums[i, j] = d;
                                }

                                Console.WriteLine($"^-СТРОКА-{i + 1}-ЗАПОЛНЕНА-^");
                                Console.WriteLine("^----------------------^");
                            }

                            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                            Console.WriteLine($"^ Кол-во строк, в которых ср. ар. < 0: {WonderfulTools.FindCountRow(nums)}");
                            Console.Write("^ Для выхода нажмите Enter 2 раза.");
                            Console.ReadKey();
                        }
                        break;
                    }
                case "2":
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("^ Вычисление значений по заданным формулам ^");
                            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");

                            SetPoint(out Point p);

                            if (p.GetX() is null && p.GetY() is null)
                                break;

                            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                            Console.WriteLine($"^ Вычисленное значение функции a: {WonderfulTools.CalcFuncA((double)p.GetX(), (double)p.GetY())}");
                            Console.WriteLine($"^ Вычисленное значение функции b: {WonderfulTools.CalcFuncB((double)p.GetX(), (double)p.GetY())}");
                            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                            Console.Write("^ Для выхода нажмите Enter 2 раза.");
                            Console.ReadKey();
                        }
                        break;
                    }
                case "3":
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("^ Нахождение суммы элементов одномерного массива A длины N ^");
                            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                            Console.Write("^ Введите длину N массива A: ");

                            input = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(input))
                                break;

                            if (!int.TryParse(input, out int N))
                                continue;

                            double[] A = new double[N];

                            Random r = new Random();
                            for (int i = 0; i < N; i++)
                                A[i] = r.Next(0, 100);

                            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                            Console.Write("^ Сгенерированный массив: ");

                            foreach (var elem in A)
                                Console.Write(elem + "; ");

                            Console.WriteLine("\n^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                            Console.WriteLine($"^ Сумма элементов: {WonderfulTools.SumElems(A)}");
                            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                            Console.Write("^ Для выхода нажмите Enter 2 раза.");
                            Console.ReadKey();
                        }
                        break;
                    }
                case "4":
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("^ Вычислить u, v, а только затем k ^");
                            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                            Console.Write("^ Введите значение a: ");

                            input = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(input))
                                break;

                            if (!double.TryParse(input, out double a))
                                continue;

                            Console.Write("^ Введите значение b: ");

                            input = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(input))
                                break;

                            if (!double.TryParse(input, out double b))
                                continue;

                            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");

                            WonderfulTools.CalcU(a, b, out double u);

                            Console.WriteLine($"^ Вычисленное значение u: {u}");

                            WonderfulTools.CalcV(a, b, out double v);

                            Console.WriteLine($"^ Вычисленное значение v: {v}");
                            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");

                            double k = 0;
                            WonderfulTools.CalcK(u, v, ref k);

                            Console.WriteLine($"^ Вычисленное значение k: {k}");
                            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                            Console.Write("^ Для выхода нажмите Enter 2 раза.");
                            Console.ReadKey();
                        }
                        break;
                    }
                case "5":
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("^ Проверить, лежат ли точки в одной четверти плоскости ^");
                            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                            Console.WriteLine("^-ИНИЦИАЛИЗАЦИЯ-ПЕРВОЙ-ТОЧКИ---------------------------^");

                            SetPoint(out Point p1);

                            if (p1.GetX() is null && p1.GetY() is null)
                                break;

                            Console.WriteLine("^-ИНИЦИАЛИЗАЦИЯ-ВТОРОЙ-ТОЧКИ---------------------------^");

                            SetPoint(out Point p2);

                            if (p2.GetX() is null && p2.GetY() is null)
                                break;

                            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");

                            if (Point.IsOneQuater(p1, p2))
                                Console.WriteLine("^ Точки лежат в одной четверти! :)");
                            else
                                Console.WriteLine("^ Точки не лежат в одной четверти! :(");
                            Console.Write("^ Для выхода нажмите Enter 2 раза.");
                            Console.ReadKey();
                        }
                        break;
                    }
                case "6":
                    {
                        Console.Clear();
                        Console.WriteLine("^ Найти площадь и периметр треугольника ^");
                        Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                        Console.WriteLine("^-ИНИЦИАЛИЗАЦИЯ-ПЕРВОЙ-ТОЧКИ------------^");

                        SetPoint(out Point p1);

                        Console.WriteLine("^-ИНИЦИАЛИЗАЦИЯ-ВТОРОЙ-ТОЧКИ---------------------------^");

                        SetPoint(out Point p2);

                        Console.WriteLine("^-ИНИЦИАЛИЗАЦИЯ-ТРЕТЬЕЙ-ТОЧКИ---------------------------^");

                        SetPoint(out Point p3);

                        Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");

                        Point.SquareOfTriangle(p1, p2, p3, out double S);
                        Point.PerimetrOfTriangle(p1, p2, p3, out double P);

                        Console.WriteLine($"^ Площадь треугольника равна {S}");
                        Console.WriteLine($"^ Периметр треугольника равен {P}");
                        Console.WriteLine($"^ точка 1: ({p1.GetX()},{p1.GetY()}), точка 2: ({p2.GetX()},{p2.GetY()}), точка 3: ({p3.GetX()},{p3.GetY()})");
                        Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                        Console.Write("^ Для выхода нажмите Enter 2 раза.");
                        Console.ReadKey();
                        break;
                    }
                case "7":
                    Application.Run(new FormOf1());
                    break;
                case "8":
                    Application.Run(new FormOf2());
                    break;
                case "9":
                    Application.Run(new FormOf3());
                    break;
                case "10":
                    Application.Run(new FormOf4());
                    break;
                case "11":
                    Application.Run(new FormOf5());
                    break;
                case "12":
                    Application.Run(new FormOf6());
                    break;
            }
        }
    }
}