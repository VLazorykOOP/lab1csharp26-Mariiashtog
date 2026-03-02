////Завдання 1 лабораторна 1
//using System;

//Console.OutputEncoding = System.Text.Encoding.UTF8;

//Console.WriteLine("--- Обчислення відстані між точками ---");

//// 1. Введення координат першої точки (a, b)
//Console.Write("Введіть координату a (x1): ");
//double a = Convert.ToDouble(Console.ReadLine());

//Console.Write("Введіть координату b (y1): ");
//double b = Convert.ToDouble(Console.ReadLine());

//// 2. Введення координат другої точки (c, d)
//Console.Write("Введіть координату c (x2): ");
//double c = Convert.ToDouble(Console.ReadLine());

//Console.Write("Введіть координату d (y2): ");
//double d = Convert.ToDouble(Console.ReadLine());

//// 3. Обчислення за формулою
//// Math.Pow(число, 2) - піднесення до квадрата
//// Math.Sqrt(число) - квадратний корінь
//double distance = Math.Sqrt(Math.Pow(c - a, 2) + Math.Pow(d - b, 2));

//// 4. Вивід результату (округлюємо до 2 знаків після коми)
//Console.WriteLine($"\nВідстань між точками ({a}; {b}) та ({c}; {d}) становить: {distance:F2}");

//// Очікування натискання клавіші перед закриттям
//Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
//Console.ReadKey();




//// --- ЗАВДАННЯ 2: Перевірка на непарність ---
//Console.WriteLine("\n--- Завдання 2: Перевірка числа ---");

//Console.Write("Введіть ціле число: ");
//// Використовуємо int, бо за умовою число ціле
//int number = Convert.ToInt32(Console.ReadLine());

//// Перевіряємо умову: якщо остача від ділення на 2 не дорівнює 0
//if (number % 2 != 0)
//{
//    Console.WriteLine($"Число {number} є НЕПАРНИМ.");
//}
//else
//{
//    Console.WriteLine($"Число {number} є ПАРНИМ.");
//}


//// --- ЗАВДАННЯ 3: Точка в області ---
//Console.WriteLine("\n--- Завдання 3: Точка в області ---");

//Console.Write("Введіть координату x: ");
//double xCoord = Convert.ToDouble(Console.ReadLine());

//Console.Write("Введіть координату y: ");
//double yCoord = Convert.ToDouble(Console.ReadLine());

//// Обчислюємо квадрат відстані від (0,0) до (x,y)
//double distanceSquared = xCoord * xCoord + yCoord * yCoord;

//// Перевірка умов
//if (yCoord < 0 || distanceSquared < 25 || distanceSquared > 100)
//{
//    // Поза областю (нижче осі X, або занадто близько/далеко від центру)
//    Console.WriteLine("Ні");
//}
//else if (yCoord == 0 || distanceSquared == 25 || distanceSquared == 100)
//{
//    // Рівно на осях або на колах
//    Console.WriteLine("На межі");
//}
//else
//{
//    // Всередині заштрихованої зони
//    Console.WriteLine("Так");
//}


//// --- ЗАВДАННЯ 4: Назва масті ---
//Console.WriteLine("\n--- Завдання 4: Визначення масті карти ---");

//Console.Write("Введіть номер масті (1-4): ");
//// Зчитуємо ціле число
//int m = Convert.ToInt32(Console.ReadLine());

//string suitName;

//// Використовуємо switch для вибору назви
//switch (m)
//{
//    case 1:
//        suitName = "піки";
//        break;
//    case 2:
//        suitName = "трефи";
//        break;
//    case 3:
//        suitName = "бубни";
//        break;
//    case 4:
//        suitName = "черви";
//        break;
//    default:
//        suitName = "невідома масть (введіть число від 1 до 4)";
//        break;
//}

//Console.WriteLine($"Назва масті: {suitName}");


//// --- ЗАВДАННЯ 5: Функція піднесення в куб різниці ---
//Console.WriteLine("\n--- Завдання 5: Куб різниці ---");

//Console.Write("Введіть перше число (a): ");
//double num1 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Введіть друге число (b): ");
//double num2 = Convert.ToDouble(Console.ReadLine());

//// Виклик нашої функції
//double cubeResult = CubeOfDifference(num1, num2);

//Console.WriteLine($"Результат ({num1} - {num2})^3 = {cubeResult}");

//// Визначення функції (методу)
//// static означає, що функція належить класу
//// double — тип значення, яке вона повертає
//double CubeOfDifference(double a, double b)
//{
//    double difference = a - b;
//    // Використовуємо Math.Pow для піднесення до степеня 3
//    return Math.Pow(difference, 3);
//}


// --- ЗАВДАННЯ 6: Обчислення виразу ---
Console.WriteLine("\n--- Завдання 6: Обчислення математичного виразу ---");

Console.Write("Введіть дійсне число a: ");
double valA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введіть дійсне число b: ");
double valB = Convert.ToDouble(Console.ReadLine());

// Обчислюємо частини виразу окремо для зручності
double part1 = valA / (Math.Pow(valA, 2) + 1);
double part2 = valB / (Math.Pow(valB, 2) + 1);

double totalResult = part1 + part2;

Console.WriteLine($"Результат виразу: {totalResult:F4}");

Console.WriteLine("\nВітаю! Лабораторна робота завершена.");
Console.WriteLine("Натисніть будь-яку клавішу для виходу...");
Console.ReadKey();