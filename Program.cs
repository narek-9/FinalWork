string[] firstArray = { "World", "!", "C#", "Hello", ":)", "Programming", "324" };

Random rnd = new Random();
string[] secondArray = new string[rnd.Next(0, 4)];

// Заполнение нового массива значениями из старого.

for (int i = 0; i < firstArray.Length; i++) // Пробегаемся по эдементам исходного масиива.
{
    for (int j = 0; j < secondArray.Length; j++) // Пробегаемся по позициям нового масиива.
    {
        secondArray[j] = firstArray[rnd.Next(firstArray.Length)];
    }
}

Console.WriteLine("[" + string.Join(", ", secondArray) + "]");

