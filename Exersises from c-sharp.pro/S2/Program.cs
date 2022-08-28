// S2.1. Составить программу:
// а) вычисления значения функции y=(7x)^2+3x+6 при любом значении x;
// б) вычисления значения функции x=(12a)^2+7a+12 при любом значении а.
System.Console.WriteLine("");

void Functions()
{
   Console.WriteLine("Дана функция y=(7x)^2+3x+6");
   int x = new Random().Next(-100, 100);
   Console.WriteLine($"Для x = {x} значение функции y равно: {Math.Pow(7 * x, 2) + 3 * x + 6}\n ");
   Console.WriteLine("Дана функция x=(12a)^2+7a+12");
   int a = new Random().Next(-100, 100);
   Console.WriteLine($"Для a = {a} значение функции x равно: {Math.Pow(12 * a, 2) + 7 * a + 12}");
}
System.Console.WriteLine("____S2.1 - Значения функции y=(7x)^2+3x+6 и x=(12a)^2+7a+12____\n ");
Functions();
System.Console.WriteLine("");

// S2.2. Дана сторона квадрата. Найти его периметр. — решение.

void PerimeterOfTheSquare(int side)
{
    int Perimeter = side * 4;
    System.Console.WriteLine($"Периметр квадрата со стороной {side} равен {Perimeter}");
}
System.Console.WriteLine("____S2.2 - Нахождение периметра квадрата по стороне____\n ");
PerimeterOfTheSquare(20);
System.Console.WriteLine("");

// S2.3. Дан радиус окружности. Найти ее диаметр. — решение.

void CircleDiameter(int radius)
{
    int diameter = radius * 2;
    System.Console.WriteLine($"Диаметр окружности с радиусом {radius} равен {diameter}");
}
System.Console.WriteLine("____S2.3 - Нахождение диаметра окружности по радиусу____\n ");
CircleDiameter(15);
System.Console.WriteLine("");

// static void Main(string[] args)
// {
//    Console.Write("Введите радиус окружности : ");
//    double r = Convert.ToDouble(Console.ReadLine());
//    double d = 2 * r;
//    Console.WriteLine("Диаметр окружности = {0}", d);
// }

// S2.4. Считая, что Земля — идеальная сфера с радиусом R=6350 км, определить расстояние
// до линии горизонта от точки В с заданной высотой h=AB над Землей.

void DistanceToTheHorizon()
{
    System.Console.Write("Введите высоту над уровнем земли в метрах...");
    double altitude = Convert.ToDouble(System.Console.ReadLine());
    double HorizonDistance = Math.Sqrt(Math.Pow(altitude + 6350, 2) - Math.Pow(6350, 2));
    System.Console.WriteLine($"Расстояние от точки с заданной высотой до линии горизонта равно {Math.Round(HorizonDistance, 3)} м.");
}
System.Console.WriteLine("____S2.4 - Расстояние от точки с заданной высотой до линии горизонта____\n ");
DistanceToTheHorizon();
System.Console.WriteLine("");

// S2.5. Дана длина ребра куба. Найти объем куба и площадь его боковой поверхности. — решение

void VolumeAndAreaOfASideOfACube()
{
    System.Console.Write("Введите длину ребра куба в см...");
    double len = Convert.ToDouble(System.Console.ReadLine());
    double vol = Math.Pow(len, 3);
    double area = 6 * Math.Pow(len, 2);
    System.Console.WriteLine($"Объём куба с длиной ребра {len} см. равна {Math.Round(vol, 2)} см3.");
    System.Console.WriteLine($"Площадь поверхности этого куба равна {Math.Round(area, 2)} см2.");
}
System.Console.WriteLine("____S2.5 - Объем куба и площадь его боковой поверхности по длине ребра____\n ");
VolumeAndAreaOfASideOfACube();
System.Console.WriteLine("");

// S2.6. Дан радиус окружности. Найти длину окружности и площадь круга.

void CircleLenghtAndSquare(double radius)
{
    double CircleLenght = 2 * Math.PI * radius;
    double CircleSquare = Math.PI * Math.Pow(radius, 2);
    System.Console.WriteLine($"Длина окружности с радиусом {radius} см. равна {Math.Round(CircleLenght, 3)} см.");
    System.Console.WriteLine($"Площадь круга с радиусом {radius} см. равна {Math.Round(CircleSquare, 3)} см2");
}
System.Console.WriteLine("____S2.6 - Длина окружности и площадь круга по радиусу____\n ");
CircleLenghtAndSquare(12);
System.Console.WriteLine("");

//  S2.7. Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее геометрическое.

void AverageOfTwoNumbers()
{
    System.Console.WriteLine("Введите два целых числа:");
    int numberA = Convert.ToInt32(System.Console.ReadLine());
    int numberB = Convert.ToInt32(System.Console.ReadLine());
    System.Console.WriteLine($"Cреднее арифметическое этих чисел равно {(numberA + numberB) / 2}");
    System.Console.WriteLine($"Cреднее геометрическое этих чисел равно {Math.Round(Math.Sqrt(numberA * numberB), 2)}");
}
System.Console.WriteLine("____S2.7 - Cреднее арифметическое и среднее геометрическое двух чисел____\n ");
AverageOfTwoNumbers();
System.Console.WriteLine("");

// S2.8. Известны объем и масса тела. Определить плотность материала этого тела.

double Density(double volume, double mass)
{
    double density = volume / mass;
    return density;
}
System.Console.WriteLine("____S2.8 - Плотность материала тела по объёму и массе____\n ");
double dens = Density(5, 25);
System.Console.WriteLine($"Плотность тела объёмом 25 м3 и массой 5 кг равна {dens} кг/м3");
System.Console.WriteLine("");

// S2.9. Известны количество жителей в государстве и площадь его территории. Определить плотность населения в этом государстве.

double PopulationDensity()
{
    System.Console.Write("Введите количество жителей государства в млн. чел...");
    double population = Convert.ToDouble(System.Console.ReadLine());
    System.Console.Write("Введите площадь государства в км2...");
    double square = Convert.ToDouble(System.Console.ReadLine());
    double density = population * 1000000 / square;
    System.Console.WriteLine($"Плотность населения этого государства {Math.Round(density, 2)} чел/км2");
    return density;
}
System.Console.WriteLine("____S2.9 - Плотность населения государства____\n ");
PopulationDensity();
System.Console.WriteLine("");

// S2.10. Составить программу решения линейного уравнения ax+b=0 (a ≠ 0).

void LinearEquation()
{
    System.Console.Write("Введите переменную 1, не равную 0...");
    double a = Convert.ToDouble(Console.ReadLine());
    if (a != 0)
    {
        System.Console.Write("Введите переменную 2...");
        double b = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine($"В уравнении ax+b=0 x = {-b / a}");
    }
    else System.Console.WriteLine("Вы ввели переменную 1, равную 0, остановка программы");
}
System.Console.WriteLine("____S2.10 - Решение линейного уравнения ax+b=0 (a не равно 0)____\n ");
LinearEquation();
System.Console.WriteLine("");

// S2.11. Даны катеты прямоугольного треугольника. Найти его гипотенузу.

// S2.12. Найти площадь кольца по заданным внешнему и внутреннему радиусам.

// S2.13.  Даны катеты прямоугольного треугольника. Найти его периметр.

// S2.13А. Даны два числа. Найти среднее арифметическое и среднее геометрическое их  модулей.

// S2.14. Даны основания и высота равнобедренной трапеции. Найти ее периметр.

// S2.14А. Даны стороны прямоугольника. Найти его периметр и длину диагонали.

// S2.15. Даны два числа. Найти их сумму, разность, произведение, а также частное от деления первого числа на второе.

// S2.16. Даны длины сторон прямоугольного параллелепипеда. Найти его объем и площадь боковой поверхности.

// S2.17. Известны координаты на плоскости двух точек. Составить программу вычисления расстояния между ними.

// S2.18. Даны основания и высота равнобедренной трапеции. Найти периметр трапеции.

// S2.19. Даны основания равнобедренной трапеции и угол при большем основании. Найти площадь трапеции.

// S2.20. Треугольник задан координатами своих вершин. Найти периметр и площадь треугольника.

// S2.21. Выпуклый четырехугольник задан координатами своих вершин. Найти площадь этого четырехугольника как сумму площадей треугольников.

// S2.22. Известна стоимость 1 кг конфет, печенья и яблок. Найти стоимость всей покупки, если купили x кг конфет, у кг печенья и z кг яблок.

// S2.23. Известна стоимость монитора, системного блока, клавиатуры и мыши. Сколько будут стоить 3 компьютера из этих элементов? N компьютеров?

// S2.24. Возраст Тани — X лет, а возраст Мити — Y лет. Найти их средний возраст, а также определить, на сколько отличается возраст каждого ребенка от среднего значения.  —  решение

// S2.25. Два автомобиля едут навстречу друг другу с постоянными скоростями V1 и  V2 км/час. Определить, через какое время автомобили встретятся, если расстояние между ними было S км.

// S2.26. Два автомобиля едут друг за другом с постоянными скоростями V1 и  V2 км/час (V1>V2). Определить, какое расстояние будет между ними через 30 минут после того, как первый автомобиль опередил второй на S км.

// S2.27. Известно значение температуры по шкале Цельсия. Найти соответствующее  значение температуры по шкале: а) Фаренгейта; б) Кельвина. Для пересчета по шкале Фаренгейта необходимо исходное значение температуры умножить на 1,8 и к результату прибавить 32, а по шкале Кельвина абсолютное значение нуля соответствует 273,15 градуса по шкале Цельсия.

// S2.28. У американского писателя-фантаста Рэя Бредбери есть роман «450 градусов  по Фаренгейту». Какой температуре по шкале Цельсия соответствует указанное в названии значение? (См. предыдущую задачу).

