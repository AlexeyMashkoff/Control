
string[] array = Array1();
string[] result = Less(array, 3);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

string[] Less(string[] input, int n) 
{
    string[] output = new string[Count(input, n)];

    for(int i = 0, j = 0; i < input.Length; i++) 
    {
        if(input[i].Length <= n) 
        {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

int Count(string[] input, int n) 
{
    int count = 0;

    for(int i = 0; i < input.Length; i++) 
    {
        if(input[i].Length <= n) 
        {
            count++;
        }
    }

    return count;
}
string[] Array1() 
{
    Console.Write("Введите любое значение через пробел: ");
    return Console.ReadLine().Split(" ");
}