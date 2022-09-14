// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11       82 -> 10           9012 -> 12
Console.WriteLine("Input Number");
int Number = Convert.ToInt32(Console.ReadLine());
int temp = Number;
int firstNum = 0;
int GetSum(int num1)
{
    while (temp != 0)
    {
        firstNum = firstNum + (temp % 10);
        temp = temp / 10;
    }
    return firstNum;

}
int sum = GetSum(Number);
Console.WriteLine(sum);