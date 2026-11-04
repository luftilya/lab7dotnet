using wonderful_tools;

namespace lab7;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("^ Лабораторная работа №7. Выполнили Илья Зеленев и Станислав Сахаров, бТИИ-251, вариант 1  ^");
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine("^ 1) Функция вычисления количества строк двумерного массива,     ^ 4) Windows Forms        ^" +
                            "\n^ в которых среднее арифметическое элементов меньше нуля.");
            Console.WriteLine("^ 2) Составить программу, содержащую функцию вычисления значений ^ 5) Windows Forms        ^" +
                            "\n^ выражений по заданным формулам (из 1 л.р.).");
            Console.WriteLine("^ 3) Составить программу, содержащую функцию для нахождения      ^ 6) Windows Forms        ^" +
                            "\n^ суммы элементов одномерного массива А длины N.");
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
                            Console.Write("^ Для выхода нажмите Enter.");
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
                            Console.Write("^ Введите значение для x: ");

                            input = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(input))
                                break;

                            if (!double.TryParse(input, out double x))
                                continue;

                            Console.Write("^ Введите значение для y: ");

                            input = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(input))
                                break;

                            if (!double.TryParse(input, out double y))
                                continue;

                            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                            Console.WriteLine($"^ Вычисленное значение функции a: {WonderfulTools.CalcFuncA(x, y)}");
                            Console.WriteLine($"^ Вычисленное значение функции b: {WonderfulTools.CalcFuncB(x, y)}");
                            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                            Console.Write("^ Для выхода нажмите Enter.");
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

                            Random r = new Random(88);
                            for (int i = 0; i < N; i++)
                                A[i] = r.Next(0, 100);

                            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                            Console.Write("^ Сгенерированный массив: ");

                            foreach (var elem in A)
                                Console.Write(elem + "; ");

                            Console.WriteLine("\n^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                            Console.WriteLine($"^ Сумма элементов: {WonderfulTools.SumElems(A)}");
                            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                            Console.Write("^ Для выхода нажмите Enter.");
                            Console.ReadKey();
                        }
                        break;
                    }
            }
        }
    }
}