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

//Console.WriteLine(QuantInt(num));
// int quantity1=quantity;
// int quantity2=quantity;
// int quantity3=quantity;

// int first=num;
// int second=num;

    
//     while (quantity-1>0)
//     {
//     first=first/10;
//     quantity--;
//     }
// Console.WriteLine($"{first}");

//    if (first==num%10)
//    {
//     while (quantity1-2>0)
//     {
//     second=second/10;
//     quantity1--;
//     }
// second=second%10;
// Console.WriteLine($"{second}");
//    }
//    else 
//    {
//     Console.WriteLine("Не полиндром");
//    return;
//    }
// Console.WriteLine($"{num%10}");
//Console.WriteLine($"{quantity1}");
// int simetry=quantity2/2;

// Console.WriteLine($"{simetry}");
int [] arr=new int[quantity];
// int i=0;
int krat=1;
// while (i<quantity)
for (int i = 0; i < quantity; i++)
{
    arr[i]=(num/(10*krat))%10;
    krat=krat*10;
    Console.Write($"{arr[i]}  ");
}
arr[quantity-1]=num%10;
int simetry=quantity/2;
int steps=1;
int count=1;
while (steps!=simetry)
{
    int smth=arr[quantity-quantity]==arr[quantity-count]?steps++:steps--;
    quantity++;
    count++;
}
if (steps<simetry) Console.WriteLine("Не полиндром");
else Console.WriteLine("Таки полиндром!!!");
// else Console.WriteLine("Не полиндром");

// int count=1;
// int rightSight=quantity;
// while (quantity!=quantity)
// {
//    int pairs= arr[quantity-rightSight]==arr[quantity-count]?1 :-1;
//    count++;
//    rightSight++;



