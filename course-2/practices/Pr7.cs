namespace PR7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            int number = 10;
            if (number > 0)
            {
                Console.WriteLine("Число положительное");
            }
            else if (number < 0)
            {
                Console.WriteLine("Число отрицательное");
            }
            else
            {
                Console.WriteLine("Число равно нулю");
            }

            // Task 2
            Console.Write("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("Вы несовершеннолетний");
            }

            else
            {
                Console.WriteLine("Вы совершеннолетний");
            }

            // Task 3
            int num = 7;
            if (num % 2 == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число нечетное");
            }

            // Task 4
            int a = 5;
            int b = -2;
            if (a > 0 && b > 0)
            {
                Console.WriteLine("Оба числа положительные");
            }
            else if (a > 0 || b > 0)
            {
                Console.WriteLine("Хотя бы одно число положительное");
            }
            else if (a < 0)
            {
                Console.WriteLine("a не положительное");
            }

            // Task 5
            Console.Write("Введите оценку: ");
            int grade = int.Parse(Console.ReadLine());
            if (grade < 3)
            {
                Console.WriteLine("Неудовлетворительно");
            }
            else if (grade == 3)
            {
                Console.WriteLine("Удовлетворительно");
            }
            else if (grade == 4)
            {
                Console.WriteLine("Хорошо");
            }
            else if (grade == 5)
            {
                Console.WriteLine("Отлично");
            }

            // Task 6
            int min = 10;
            int max = 100;
            int n = int.Parse(Console.ReadLine());
            if (n >= min && n <= max)
            {
                Console.WriteLine("Число в диапазоне");
            }
            else
            {
                Console.WriteLine("Число вне диапазона");
            }

            // Task 7
            Console.Write("Введите сторону треугольника: ");
            int a_1 = int.Parse(Console.ReadLine());
            Console.Write("Введите вторую сторону треугольника: ");
            int b_1 = int.Parse(Console.ReadLine());
            Console.Write("Введите третью сторону треугольника: ");
            int c_1 = int.Parse(Console.ReadLine());
            if (a_1 == b_1 && b_1 == c_1 )
            {
                Console.WriteLine("Треугольник равносторонний");
            }
            else if (a_1 == b_1 || a_1 == c_1 || b_1 == c_1)
            {
                Console.WriteLine("Треугольник равнобедренный");
            }
            else if (a_1 != b_1 && b_1 != c_1 && a_1 != c_1)
            {
                
            }
        }
    }
}