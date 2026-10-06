namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            int b = 5;
            int Sum = a + b;
            int Diff = a - b;
            int Product = a * b;
            int Div = a / b;
            int Mod = a % b;

            // 2 задание

            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            // 3 задание

            Console.Write("Сумма чисел - Введите число 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Введите число 2: ");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("Сумма: " + sum);

            // 4 задание

            Console.Write("Площадь - Введите число 1: ");
            int numm1 = int.Parse(Console.ReadLine());
            Console.Write("Введите число 2: ");
            int numm2 = int.Parse(Console.ReadLine());
            int prod = numm1 * numm2;
            Console.WriteLine("Произведение: " + prod);

            // 5 задание

            Console.Write("Температура - Введите температуру в градусах Цельсия: ");
            int temp = int.Parse(Console.ReadLine());
            int temp_F = (temp * 9 / 5) + 32;
            Console.WriteLine("Температура в градусах Фаренгейта: " + temp_F);
            // 6 задание
            Console.Write(" Среднее арифметическое - Введите число: ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Введите число: ");
            int e = int.Parse(Console.ReadLine());
            Console.Write("Введите число: ");
            int c = int.Parse(Console.ReadLine());

            int middle = (d + e + c) / 3;
            Console.WriteLine("Среднее арифметическое: " + middle);

            // 7 задание
            Console.Write("Операции с двумя числами - Введите число: ");
            int nummm1 = int.Parse(Console.ReadLine());
            Console.Write("Введите число: ");
            int nummm2 = int.Parse(Console.ReadLine());
            int sum3 = nummm1 + nummm2;
            int diff = nummm1 - nummm2;
            int product = nummm1 * nummm2;
            int div = nummm1 / nummm2;
            Console.WriteLine("Сумма: " + sum3);
            Console.WriteLine("Разность: " + diff);
            Console.WriteLine("Произведение: " + product);
            Console.WriteLine("Частное: " + div);
        }
    }
}
