Console.WriteLine("Простейший бинарный поиск");

int number = int.Parse(Console.ReadLine());
int low = 0;
int[] n = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var high = n.Length-1;
var res  = 0;

while (low <= number)
{
    res = (low + high)/2;
    var index = n[res];
    if(index == number)
    {
        break;
    }
    else if(number < index)
    {
        high = res - 1;
    }
    else
    {
        low = res + 1;
    }
}
Console.WriteLine($"позиция в массиве {res}, значение {n[res]}");

