//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
Console.Clear();
Console.Write("Введите числа через пробел: ");
string elements = Console.ReadLine();
int[] baseArray = GetArrayFromString(elements);


int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

int FindElement(int[] baseArray)
{   
    int numbers = 0;
    foreach (var item in baseArray)
    {
        if (item > 0)
        numbers = numbers + 1;
    }
    return numbers;
}

Console.Write($"Колличество чисел больше 0:   {FindElement(baseArray)} ");
