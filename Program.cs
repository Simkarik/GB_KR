Console.WriteLine($"Enter quantity of strings you want to type in: ");
int num = int.Parse(Console.ReadLine());
string[] array = new string[num];

void GetMas(string[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        Console.WriteLine($"Enter string {i+1}: ");
        mas[i] = Console.ReadLine();
    }
}

void PrintMass(string[] mass)
{
    int pos = 0;
    while (pos< mass.Length -1)
    {
        Console.Write($"{mass[pos]}, ");
        pos++;
    }
    Console.Write(mass[pos]);
    Console.WriteLine();
}



GetMas(array);
PrintMass(array);