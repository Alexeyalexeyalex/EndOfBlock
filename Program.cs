using static System.Console;

Clear();
WriteLine("Введите массив строк через пробел: ");
string[] array = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
string[] resultArray = new string[array.Length];

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length<=3)
    {
        resultArray[i] = array[i];
    }
}

WriteLine($"{string.Join(" ", array)} -> {string.Join(" ", resultArray)}");