// Задача 8. Программа показывает все четные числа от 1 до введенного числа.
Console.Write("Input posiniv number: ");
int number = Convert.ToInt32(Console.ReadLine());
int current = 2;
while(current <= number )
{
    Console.WriteLine(current +" ");
     current = current +2;
}