// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
//  сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

 Console.WriteLine("Введите количество чисел :");
        int m = int.Parse(Console.ReadLine());

        int count = 0;

        for (int i = 0; i < m; i++)
        {
            Console.WriteLine($"Введите число {i + 1}:");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                count++;
            }
        }

        Console.WriteLine($"Количество чисел, больших нуля: {count}");

    

    

