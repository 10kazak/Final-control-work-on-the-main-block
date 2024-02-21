Console.Write("Введите желаемый размер массива строк: ");
int N = Convert.ToInt32(Console.ReadLine());
string[] array_strings = new string[N];
string[] new_array_strings = new string[N];
int c = 0;
for (int i = 0; i < array_strings.Length; i++)
{
    Console.Write($"Введите {i + 1} строку:");
    array_strings[i] = Console.ReadLine();
    if (array_strings[i].Length <= 3)
    {
        new_array_strings[c] = array_strings[i];
        c++;
    }
}


Console.Write("[");
for (int i = 0;i < N; i++)
{
    Console.Write($"'{array_strings[i]}' ");
}
Console.Write("] >> [");
for (int i = 0; i < c; i++)
{
    Console.Write($"'{new_array_strings[i]}' ");
}
Console.Write("]");