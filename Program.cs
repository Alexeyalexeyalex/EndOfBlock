using static System.Console;

Clear();
WriteLine("Введите массив строк через пробел: ");
string[] array = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) j++;
}
string[] resultArray = new string[j];
j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        resultArray[j] = array[i];
        j++;
    }
}

WriteLine($"[{string.Join(",", array)}] -> [{string.Join(",", resultArray)}]");