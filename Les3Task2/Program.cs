
static void PrintSguares(int limit)
{
    int i = 1;
    while (i <= limit)
    {
        Console.WriteLine($"{i} => {i*i} ");
        i++;
    }
}
// PrintSguares(5);
// PrintSguares(10);
// PrintSguares(15);
PrintSguares(20);

