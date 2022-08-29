double a = 2,  b = -6, c = 18, temp;
System.Console.WriteLine($"a = {a}, b = {b}, c = {c}");

// S3.1 Составить программу обмена значениями двух переменных величин.

temp = a;
a = b;
b = temp;
System.Console.WriteLine($"3.1 a = b = {a}, b = a = {b}");


a = 2;
b = -6;

// 2. Cоставить программу обмена значениями трех переменных величин а, b, c
// а) b присвоить значение c, а присвоить значение b, с присвоить значение а;
// б) b присвоить значение а, с присвоить значение b, а присвоить значение с.

// 2а

temp = a;
a = b;
b = c;
c = temp;
System.Console.WriteLine($"3.2a a = b = {a}, b = c = {b}, c = a = {c}");

// Можно так:
// (a , b , c) = (b , c , a);

a = 2;
b = -6;
c = 18;

// 2б

double[] mass = {a, b, c};
temp = mass[0];
mass[0] = c;
mass[2] = mass[1];
mass[1] = temp;
System.Console.WriteLine($"3.2б a = c = {mass[0]}, b = a = {mass[1]}, c = b = {mass[2]}");

// S3.3. Дано вещественное число а. Пользуясь только операцией умножения, получить:
// а) a^4 за две операции;

double A = a * a;
A = A * A;
System.Console.WriteLine($"3.3а: a^4 = {A}");

// б) a^6  за три операции;

A = a * a;
A = A * a;
A = A * A;
System.Console.WriteLine($"3.3б: a^6 = {A}");

// в) a^7 за четыре операции;

A = a * a;
A = A * a;
A = A * A;
A = A * a;
System.Console.WriteLine($"3.3в: a^7 = {A}");

// г) a^8  за три операции;

A = a * a;
A = A * A;
A = A * A;
System.Console.WriteLine($"3.3г: a^8 = {A}");

// д) a^9 за четыре операции;

A = a * a;
A = A * A;
A = A * A;
A = A * a;
System.Console.WriteLine($"3.3д: a^9 = {A}");

// е) a^10  за четыре операции.

A = a * a;
A = A * A;
A = A * a;
A = A * A;
System.Console.WriteLine($"3.3е: a^10 = {A}");


// S3.4. Дано вещественное число a. Пользуясь только операцией умножения, получить:

// а) a^3 и a^10 за четыре операции;

A = a * a; // a^2
double B = A * a; // a^3
double C = A * B; // a^5
C = C * C; // a^10
System.Console.WriteLine($"3.4а: a^3 = {B}, a^10 = {C}");

// б) a^4 и a^20 за пять операций;

A = a * a; // a^2
A = A * A; // a^4
B = A * A; // a^8
C = B * B; // a^16
C = C * A; // a^20
System.Console.WriteLine($"3.4б: a^4 = {A}, a^20 = {C}");

// в) a^5 и a^13 за пять операций;

A = a * a; // a2
B = A * a; // a3
C = A * B; // a5
double D = C * C; // a10
D = D * B; // a13
System.Console.WriteLine($"3.4в: a^5 = {C}, a^13 = {D}");

// г) a^5 и a^19 за пять операций;

A = a * a; // a^2
A = A * A; // a^4
B = A * a; // a^5
C = A * B; // a^9
D = B * B; // a^10
D = D * C; // a^19 - pа пять операций невозможно, кажется
System.Console.WriteLine($"3.4г: a^5 = {B}, a^19 = {D}");

// д) a^2, a^5 и a^17 за шесть операций;

A = a * a; // a^2
B = A * A; // a^4
B = B * a; // a^5
C = B * B; // a^10
C = C * B; // a^15
D = C * A; // a^19
System.Console.WriteLine($"3.4д: a^2 = {A}, a^5 = {B}, a^17 = {D}");

// е) a^4, a^12 и a^28 за шесть операций.

A = a * a; // a^2
A = A * A; // a^4
B = A * A; // a^8
B = B * A; // a^12
C = B * B; // a^24
C = C * A; // a^19
System.Console.WriteLine($"3.4е: a^4 = {A}, a^12 = {B}, a^28 = {C}");

// S3.5. Чему будет равно 10^10 по Вашему алгоритму?

a = 10;

A = a * a; // a^2
B = A * a; // a^3
B = A * B; // a^5
C = B * B; // a^10
System.Console.WriteLine($"3.5: 10^10 = {C}");