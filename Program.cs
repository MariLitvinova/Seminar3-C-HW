// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// void Polindrom (int n){
//     if ((n/10000) == (n-n/10*10) & (n/1000- n/10000*10) == (n/10-n/100*10)){
//         Console.WriteLine("да");
//     }
//     else {
//         Console.WriteLine("нет");
//     }
        
// }
// Console.WriteLine("Введите пятизначное число");
// int number = Convert.ToInt32(Console.ReadLine());
// Polindrom(number);

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// void Distance(int x1, int y1, int z1, int x2, int y2, int z2){
//     double d = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));
//     Console.WriteLine ($"Расстояние = {Math.Round(d,2)}");
// }
// Console.WriteLine("Введите координату первой точки x1");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату первой точки y1");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату первой точки z1");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату второй точки x2");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату второй точки y2");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату второй точки z2");
// int z2 = Convert.ToInt32(Console.ReadLine());
// Distance(x1, y1, z1, x2, y2, z2);

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
void Table (int n){
    for(int i=1; i<=n; i++){
       int cube = Convert.ToInt32(Math.Pow(i,3));
       Console.WriteLine(cube);
    }
}
Console.WriteLine("Таблица кубов:");
Table(n);