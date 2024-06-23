namespace ConditionalJumpOperatorsAndLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) Пользователь вводит число от 1 до 9999 (сумму выдачи в банкомате).
            //Необходимо вывести на экран введенную сумму и в конце написать название валюты
            //с правильным окончанием. Например: 1 доллар, 70 долларов.
            //Для решения этой задачи вам необходимо будет применять оператор % (остаток от деления).
            Console.WriteLine("Первое задание");
            Console.Write("Введите число 1-9999: ");
            int amount = int.Parse(Console.ReadLine());

            if (amount < 1 || amount > 9999)
            {
                Console.WriteLine("Ошибка, попробуйте еще раз");
                return;
            }
            else
            {
                string dollar;
                if (amount == 1)
                    dollar = "доллар";
                else if (amount == 4)
                    dollar = "доллара";
                else
                    dollar = "долларов";

                Console.WriteLine($"{amount} {dollar}");
            }

            //2) Пользователь вводит число с клавиатуры.
            //С использованием цикла for проверить, является ли это число простым.
            Console.WriteLine("\nВторое задание");
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            bool isPrime = true;

            if (number <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"{number} простое число");
            }
            else
            {
                Console.WriteLine($"{number} не простое число");
            }

            //3) Пользователь вводит число с клавиатуры.
            //С помощью цикла while вывести все его цифры справа налево.
            Console.WriteLine("\nТретье задание");
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Новое число: ");
            while (num > 0)
            {
                int digit = num % 10;
                Console.Write(digit);
                num /= 10;
            }
            Console.WriteLine("");

            //4) Пользователь вводит число с клавиатуры.
            //С использованием цикла for проверить, является ли это число числом Армстронга.
            Console.WriteLine("\nЧетвертое задание");
            Console.Write("Введите число: ");
            int ArmstrongNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            int temp = ArmstrongNumber;

            while (temp > 0)
            {
                int digit = temp % 10;
                sum += digit * digit * digit;
                temp /= 10;
            }

            bool isArmstrong = ArmstrongNumber == sum;
            Console.WriteLine(isArmstrong ? $"{ArmstrongNumber} - число Армстронга" : $"{ArmstrongNumber} - не является числом Армстронга");

            //5) Начальный вклад в банке равен 10000 грн.
            //Через каждый месяц размер вклада увеличивается на P процентов от имеющейся суммы
            //(P — вещественное число, 0 < P < 25). Значение Р программа должна получать у пользователя.
            //По данному P определить, через сколько месяцев размер вклада превысит 11000 грн.,
            //и вывести найденное количество месяцев K(целое число) и итоговый размер вклада S(вещественное число).
            Console.WriteLine("\nПятое задание");
            double initialDeposit = 10000;

            Console.Write("Введите значение P (0 < P < 25): ");
            double P = double.Parse(Console.ReadLine());

            if (P <= 0 || P >= 25)
            {
                Console.WriteLine("Значение P должно быть в пределах 0 < P < 25");
                return;
            }

            int months = 0;

            while (initialDeposit <= 11000)
            {
                initialDeposit += initialDeposit * (P / 100);
                months++;
            }

            Console.WriteLine($"Количество месяцев: {months}");
            Console.WriteLine($"Итоговый размер вклада: {initialDeposit:F1}");
        }
    }
}
