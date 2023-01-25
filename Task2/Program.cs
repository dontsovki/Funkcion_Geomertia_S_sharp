// Из отрезка (1-100) находим наибольшие число

int number = new Random().Next(10,100);
Console.WriteLine(number);

if (number/10 > number%10)  //сравнение
{
    Console.WriteLine(number/10);
}
else
{
    Console.WriteLine(number%10);
}