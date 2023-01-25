// Функция из отрезка (1-100) находим наибольшие число

int number = new Random().Next(1,100);
Console.WriteLine($"длина отрезка: {number}");

if (number/10 > number%10)  //сравнение
{
    Console.WriteLine($"наименьшее число: {number/10}");
}
else
{
    Console.WriteLine($"наибольшее число: {number%10}");
}