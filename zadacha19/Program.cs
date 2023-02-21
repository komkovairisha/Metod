// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
string number = " ";
number = Console.ReadLine();

void Show(string str)
{
    char[] array = str.ToCharArray();
    Array.Reverse(array);
    string str2 = new string(array);

    if (number!.Length == 5)
    {
       Console.Write(number);
    }
  else Console.WriteLine($"вы ввели не пятизначное число");

     if (str == str2)

        {
        Console.WriteLine(" палиндром");
        }
    else
        {
       Console.WriteLine(" не палиндром");
        }
}

Show(number); 
