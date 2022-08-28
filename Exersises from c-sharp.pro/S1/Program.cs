// S1.1. Вывести на экран число с точностью до сотых.

double Number1 = 5.45245545542111;
System.Console.WriteLine($"Число {Number1}, округлённое до сотых: {Math.Round(Number1, 2)}");

// S1.2. Вывести на экран число e (основание натурального логарифма) с точностью до десятых.

double fractional = 0;
double reminder = 1;

for (double i = 2; i <= 10; i++)
{
    reminder = reminder * i;
    fractional = fractional + 1 / reminder;
}

double e = 2 + fractional;

System.Console.WriteLine($"Число e равно {Math.Round(e, 1)}");

// Возможное решение - Console.WriteLine(Math.Round(Math.E, 1));
// Или Console.WriteLine(«{0:N1}», Math.E);

// S1.3. Составить программу вывода на экран числа, вводимого с клавиатуры. Выводимому числу должно предшествовать сообщение «Вы ввели число».

System.Console.Write("Введите число...");
System.Console.WriteLine("Вы ввели число " + System.Console.ReadLine());

// S1.4. Составить программу вывода на экран числа, вводимого с клавиатуры. После выводимого числа должно следовать сообщение » — вот какое число Вы  ввели».

System.Console.Write("Введите число...");
System.Console.WriteLine(System.Console.ReadLine() + " — вот какое число Вы ввели");

// S1.5. Вывести на одной строке числа 1, 13 и 49 с одним пробелом между ними.

int NumA = 1, NumB = 13, NumC = 49;
System.Console.WriteLine($"{NumA} {NumB} {NumC}");

// S1.6. Вывести на одной строке числа 7, 15 и 100 с двумя пробелами между ними.

int NumD = 7, NumE = 15, NumF = 100;
System.Console.WriteLine($"{NumD}  {NumE}  {NumF}");

// S1.7. Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.

System.Console.WriteLine("Введите три числа...");
System.Console.WriteLine($"{System.Console.ReadLine()}  {System.Console.ReadLine()}  {System.Console.ReadLine()}");

// Ещё решение:
// Random rnd = new Random();
// int a = rnd.Next(0, 10);
// int b = rnd.Next(0, 10);
// int c = rnd.Next(0, 10);
// Console.WriteLine($"{a}  {b}  {c}");

// S1.8. Составить программу вывода на экран в одну строку четырех любых чисел  с одним пробелом между ними.

int NumG = new Random().Next(1, 100); 
int NumH = new Random().Next(1, 100);
int NumI = new Random().Next(1, 100);
int NumJ = new Random().Next(1, 100);
System.Console.WriteLine($"{NumG}  {NumH}  {NumI}  {NumJ}");

// S1.9. Вывести на экран числа 50 и 10 одно под другим.

int NumK = 18, NumL = 455;
System.Console.WriteLine($"{NumK}\n{NumL}");

// S1.10. Вывести на экран числа 5, 10 и 21 одно под другим.

int NumM = 5, NumN = 10, NumO = 21;
System.Console.WriteLine($"{NumM}\n{NumN}\n{NumO}");

// S1.11. Составить программу вывода на экран «столбиком» четырех любых чисел.

int NumP = new Random().Next(1, 100); 
int NumQ = new Random().Next(1, 100);
int NumR = new Random().Next(1, 100);
int NumS = new Random().Next(1, 100);
System.Console.WriteLine($"{NumP}\n{NumQ}\n{NumR}\n{NumS}");

// Random random_num = new Random();

// for (int i = 0; i < 4; i++)
// {
// Console.WriteLine(random_num.Next());
// }

// S1.12. Составить программу вывода на экран следующей информации:
// 5 10
// 7 см

System.Console.WriteLine($"5 10\n7 см");

// S1.13. Составить программу вывода на экран следующей информации:
// 2 кг
// 13 17

System.Console.WriteLine($"2 кг\n13 17");