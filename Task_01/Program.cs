// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

int A = Prompt("Введите число А: ");
int B = Prompt("Введите число B: ");

if(A < 0|| B < 0)
    {
    Console.WriteLine("Вы ввели ненатуральное число");
    }

int value = Degree(A, B);
Console.WriteLine($"Число {A} в степени {B} равняется {value}");

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int value = int.Parse(strValue);
    return value;
}

int Degree(int num1, int num2)
{
    int result = num1;
    for (int i = 1; i < num2; i++)
    {
        result = result * num1;
    }
    return result;
}

