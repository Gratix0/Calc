// See https://aka.ms/new-console-template for more information
while (true)
{

    Console.WriteLine("Выберите операцию");
    Console.WriteLine("1. Сложение двух чисел");
    Console.WriteLine("2. Вычитание двух чисел");
    Console.WriteLine("3. Умножение двух чисел");
    Console.WriteLine("4. Деление двух чисел");
    Console.WriteLine("5. Возведение в степень");
    Console.WriteLine("6. Найти квадратный корень");
    Console.WriteLine("7. Найти 1 процент от числа");
    Console.WriteLine("8. Найти факториал от числа");
    Console.WriteLine("9. Выход из программы");
    try
    {
        int i = Convert.ToInt32(Console.ReadLine());
        while (i <= 8)
        {

            if (i == 1)
            {
                Console.WriteLine("Введите первое число");
                int firstNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                int lastNum = Convert.ToInt32(Console.ReadLine());
                int result = firstNum + lastNum;
                Console.WriteLine(result);
                break;
            }
            if (i == 2)
            {
                Console.WriteLine("Введите первое число");
                int firstNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                int lastNum = Convert.ToInt32(Console.ReadLine());
                int result = firstNum - lastNum;
                Console.WriteLine(result);
                break;
            }
            if (i == 3)
            {
                Console.WriteLine("Введите первое число");
                Console.WriteLine("Введите второе число");
                int firstNum = Convert.ToInt32(Console.ReadLine());
                int lastNum = Convert.ToInt32(Console.ReadLine());
                int result = firstNum * lastNum;
                Console.WriteLine(result);
                break;
            }
            if (i == 4)
            {
                Console.WriteLine("Введите первое число");
                int firstNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                int lastNum = Convert.ToInt32(Console.ReadLine());
                int result = firstNum / lastNum;
                Console.WriteLine(result);
                break;
            }
            if (i == 5)
            {
                Console.WriteLine("Введите первое число");
                int firstNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                int lastNum = Convert.ToInt32(Console.ReadLine());
                double result = Math.Pow(firstNum, lastNum);
                Console.WriteLine($"Результат равен: {result}");
                break;
            }
            if (i == 6)
            {
                Console.WriteLine("Введите число");
                double firstNum = Convert.ToInt32(Console.ReadLine());
                double result = Math.Sqrt(firstNum);
                Console.WriteLine($"Квадратный корень числа равен: {result}");
                break;
            }
            if (i == 7)
            {
                Console.WriteLine("Введите число");
                double firstNum = Convert.ToDouble(Console.ReadLine());
                double result = (firstNum / 100);
                Console.WriteLine($"1% равен: {result}");
                break;
            }
            if (i == 8)
            {
                Console.WriteLine("Введите число");
                int firstNum = Convert.ToInt32(Console.ReadLine());
                int factorial = 1;
                for (int a = 2; a <= firstNum; a++)
                {
                    factorial *= a;
                }
                Console.WriteLine($"Факториал числа равен: {factorial}");
                break;
            }

        }
        if (i == 9)
        {
            break;
        }
        
    }
    catch (Exception)
    {
        Console.WriteLine("Tôi có thể là Gook, nhưng bạn không thể phá vỡ tôi");
    }
    



}
