// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Prompt(string message)
{
	Console.Write(message);
	string strValue = Console.ReadLine();
	int value = int.Parse (strValue);
	return value;
}

int Summ(int value)
{
	int sum = 0;
	for(int i = 1; i <= value; i++)
	{
		sum = sum + i;
	}
	return sum;
}

int number = Prompt("Введите число:");
int result = Summ(number);
Console.WriteLine($"Сумма чисел от 1 до {number} равно {result}");
