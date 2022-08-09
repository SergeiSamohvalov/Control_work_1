string[] array;
Console.WriteLine("Введите массив строк через пробел");
string arr = Console.ReadLine()!;
array = arr!.Split(' ');
Console.WriteLine();
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
var result = new string[array.Length];
var arrayelementsize = 0;
foreach (var value in array)
{
    if (value.Length <= 3)
    {
        result[arrayelementsize] = value;
        arrayelementsize++;
    }
}
Console.WriteLine("Результат:");
Console.WriteLine(string.Join(Environment.NewLine, result, 0, arrayelementsize));
