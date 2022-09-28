// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введи число, дабы прильнуть, полидром ли: ");
int num=Convert.ToInt32(Console.ReadLine());

int QuantInt(int number)
{
    int count=0;
    while (number>0)
    {
    number=number/10;
    count++;
    }
    return count;
}

int quantity=QuantInt(num);
Console.WriteLine(QuantInt(num));
int quantity1=quantity;

int first=num;
int second=num;
    
    while (quantity-1>0)
    {
    first=first/10;
    quantity--;
    }
Console.WriteLine($"{first}");

   if (first==num%10)
   {
    while (quantity1-2>0)
    {
    second=second/10;
    quantity--;
    }
Console.WriteLine($"{second}");
   }





