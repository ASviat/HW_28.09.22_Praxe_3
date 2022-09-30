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

for (int i = 0; i < quantity; i++)
{
    arr[i]=(num/(10*krat))%10; // 12345/100=123 мб добавить заполнение для первой позиции. Помни, что цикл перевернут! С этим разобраться, чтобы нормально писался
    krat=krat*10;
    Console.Write($"{arr[i]}");
}
// arr[quantity-1]=(num/10)%10;
// arr[quantity-rightSide]=num%10;

// int simetry=quantity/2;
// int steps=0;
// int count=1;

// while (arr[quantity-rightSide]==arr[quantity-count]&&count-1!=simetry)
// {
//     rightSide--;
//     count++;
//     steps++;
// }
// Console.WriteLine($">{arr[4]}");
// Console.WriteLine($"steps>{steps}");

// if (steps<simetry) Console.WriteLine("Не полиндром");
// else Console.WriteLine("Таки полиндром!!!");


//Console.WriteLine($"{}");

