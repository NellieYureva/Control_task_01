Console.Clear();
Console.Write("Введите количество элементов массива: ");
int k = Convert.ToInt32(Console.ReadLine());
string [] Array = new string [k];
void array(string [] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива");
        Array [i] = Console.ReadLine()!;
    }
}
string [] symbol (string [] Array)
{
    int n = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if(Array[i].Length <= 3)
        n++;
    }
    string [] rez = new string [n];
    int j = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if(Array[i].Length <= 3)
        {
        rez[j] = Array[i];
        j++;
        }
    }
    return rez;
}