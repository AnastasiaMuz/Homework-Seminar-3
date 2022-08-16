//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine ("Введите число N: ");
int N = Convert.ToInt32 (Console.ReadLine ());

int counter = 1;

while (counter <= N)
{
    double res = Math.Pow (counter,3);
    Console.Write (res + " ");
    counter ++;
}