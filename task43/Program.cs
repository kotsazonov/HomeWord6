//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных
//   уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

 Console.WriteLine("Введите значения k1, b1, k2 и b2:");

        // Ввод коэффициентов прямых
        Console.Write("k1: ");
        double k1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("b1: ");
        double b1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("k2: ");
        double k2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("b2: ");
        double b2 = Convert.ToDouble(Console.ReadLine());

        // Проверка на параллельность прямых
        if (k1 == k2)
        {
            Console.WriteLine("Прямые параллельны. Точки пересечения не существует.");
        }
        else
        {
            // Вычисление координат точки пересечения
            double x = (b2 - b1) / (k1 - k2);
            double y = k1 * x + b1;

            Console.WriteLine($"Точка пересечения: ({x}, {y})");
        }

        Console.ReadLine();
    

