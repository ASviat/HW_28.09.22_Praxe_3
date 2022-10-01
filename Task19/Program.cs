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


int [] arr=new int[quantity];
int krat=1;
int rightSide=quantity;
arr[0]=num%10;
for (int i = 1; i < quantity; i++)
{
    arr[i]=(num/(10*krat))%10;
    krat=krat*10;
    Console.Write($"{arr[i]}");
}

for (int i = 0; i < quantity; i++)
{
    Console.Write($">>{arr[i]}  ");
}

int simetry=quantity/2;
 int steps=0;
 int count=1;

while (arr[quantity-rightSide]==arr[quantity-count]&&count-1!=simetry)
{
    rightSide--;
    count++;
    steps++;
}

if (steps<simetry) Console.WriteLine("Не полиндром");
else Console.WriteLine("Таки полиндром!!!");