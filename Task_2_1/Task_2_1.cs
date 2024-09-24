using System;
using System.Linq;

int[] numbers;
int count;

while (true)
{
    try
    {
        Console.Write("Введите количество цифр (от 3 до 7): ");
        count = int.Parse(Console.ReadLine());

        if (count < 3 || count > 7)
        {
            throw new ArgumentOutOfRangeException("Количество должно быть от 3 до 7");
        }

        numbers = new int[count];
        break;
    }
    catch (FormatException)
    {
        Console.WriteLine("Ошибка: Введите корректное число.");
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine($"Ошибка: {ex.Message}");
    }
}

for (int i = 0; i < count; i++)
{
    while (true)
    {
        try
        {
            Console.Write($"Введите цифру {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());

            if (numbers[i] < 0 || numbers[i] > 9)
            {
                throw new ArgumentOutOfRangeException("Введите цифру от 0 до 9");
            }

            break;
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Введите корректную цифру.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}

double average = numbers.Average();
Console.WriteLine($"Среднее арифметическое: {average:F2}");
