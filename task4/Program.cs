//Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine ("Введите первое число: ");
int numbera = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите второе число: ");
int numberb = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите третье число: ");
int numberd = Convert.ToInt32 (Console.ReadLine());

if (numbera > numberb & numbera > numberd)
{
    Console.WriteLine(numbera);
}
if (numberb > numbera & numberb > numberd)
{
    Console.WriteLine(numberb);
}
if (numberd > numbera & numberd > numberb)
{
    Console.WriteLine(numberd);
}