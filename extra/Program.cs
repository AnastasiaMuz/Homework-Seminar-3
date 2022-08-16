//Разворот массива
Console.WriteLine ("Введите число: ");
string number = (Console.ReadLine ());

char[] arr = number.ToCharArray();
Array.Reverse (arr);
Console.WriteLine (arr);
