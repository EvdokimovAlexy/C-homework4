// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Input NumberA");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input NumberB");
int NumberB = Convert.ToInt32(Console.ReadLine());
int Getexponentiate(int num1)
{
    int index = 0;
    int count = 1;
    int length = NumberB;
    int temp = NumberA;
    while (index < length)
    {
        count = count * NumberA;
        index++;
    }
    return count;
}
int Number = Getexponentiate(NumberA);
Console.WriteLine(Number);