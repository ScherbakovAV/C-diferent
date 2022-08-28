System.Console.Clear();

//__________________________________________________________________________________________
// 1,2. Чтение и вывод строки
// 5. Приветствие с условием
Console.Write("Enter yor name...");
String UserName = Console.ReadLine()!;
if (UserName.ToLower() == "anatoliy")
{
    Console.WriteLine($"Oh, this is a dear {UserName}! Welcome!");
}
else
{
    Console.WriteLine($"Hello, {UserName}!");
}
Console.WriteLine("");


//__________________________________________________________________________________________
// 3. Ввод двух целых чисел пользователем / где записаны 2 целых числа /
// где два числа генерируются случайным образом -> нахождение суммы этих чисел
// 4. Нахождение частного этих чисел

Console.WriteLine("---Testing first option: enter from user---");
Console.WriteLine("");

Console.Write("Enter first number...");
double NumberFromUser1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");

Console.Write("Enter second number...");
double NumberFromUser2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine($"{NumberFromUser1} + {NumberFromUser2} = {NumberFromUser1 + NumberFromUser2}");

Console.WriteLine($"{NumberFromUser1} / {NumberFromUser2} = {NumberFromUser1 / NumberFromUser2}");

Console.WriteLine($"{NumberFromUser1}^3 = {Math.Pow(NumberFromUser1, 3)}");

Console.WriteLine($"{NumberFromUser2}^2 = {Math.Pow(NumberFromUser2, 2)}");

Console.WriteLine("");

Console.WriteLine("---Testing second option: numbers are predetermined---");
Console.WriteLine("");

int NumberExist1 = 50;
int NumberExist2 = 38;

Console.WriteLine("Predetermined numbers are " + NumberExist1 + " and " + NumberExist2);
Console.WriteLine("");
Console.WriteLine($"{NumberExist1} + {NumberExist2} = {NumberExist1 + NumberExist2}");

Console.WriteLine("");

Console.WriteLine("---Testing third option: numbers are random---");
Console.WriteLine("");

int NumberRandom1 = new Random().Next(-100, 101);
int NumberRandom2 = new Random().Next(-100, 101);

Console.WriteLine("Two random numbers are " + NumberRandom1 + " and " + NumberRandom2);
Console.WriteLine("");
Console.WriteLine($"{NumberRandom1} + {NumberRandom2} = {NumberRandom1 + NumberRandom2}");

Console.Write("Press Enter to exit");
Console.ReadLine();

//__________________________________________________________________________________________

