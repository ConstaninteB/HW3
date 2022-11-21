// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


// Console.WriteLine("Введите три координаты первой точки А: ");
// string a = Console.ReadLine();
// Console.WriteLine("Введите три координаты первой точки B: ");
// string b = Console.ReadLine();

// if ( a.Length == 5 && a.Length == 5)
// {
//     double distance = Math.Sqrt(Math.Pow(a[0] - b[0], 2) + Math.Pow(a[2] - b[2],2) + Math.Pow(a[4] - a[4],2));
//     Console.WriteLine(distance);
// }
// else 
// {
//     Console.WriteLine("Неправильно введены координаты,точно скопируйте координаты из условия включая запятые без пробелов");
// }
// Console.Write(a.Length + b.Length);
// **Сначала мне показалось, что будет легче через массив посчитать, но уперся в такую проблему что запятую и знак "-" он считает 
// как индекс массива, есть ли способ это обойти?

Console.WriteLine("Введите первую координату точки А:"); 
int ax = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вторую координату точки А: ");
int ay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первую координату точки А: ");
int az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вторую координату точки B: ");
int bx = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вторую координату точки B: ");
int by = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вторую координату точки B: ");
int bz = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay- by,2)+ Math.Pow(az- bz,2));
Console.Write(distance);

