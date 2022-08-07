int a = new Random().Next(100,999);
Console.WriteLine(a);
int value1 = a/100;
int value2 = a%10;
Console.WriteLine(value1);
Console.WriteLine(value2);
a = value1*10 + value2;
Console.WriteLine(a);
