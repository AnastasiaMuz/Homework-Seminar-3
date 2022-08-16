//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine ("Введите число: ");
string number = (Console.ReadLine ());

char[] arr = number.ToCharArray();
Array.Reverse (arr);
Console.WriteLine (arr);



    if (number[0] == arr[0] & number[1] == arr[1] & number[2] == arr[2] & number[3] == arr[3] & number[4] == arr[4])
{
   Console.WriteLine ("да");
}
 
    else
{
     Console.WriteLine ("нет");
}
