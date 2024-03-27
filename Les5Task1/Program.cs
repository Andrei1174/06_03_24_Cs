
// задачаа №1 Вычислить факториал от натурального числа N
int Factorial(int num)
{
    if(num == 1 || num == 0)  
    {
    Console.WriteLine($"Stop: {num}");
    return 1;
    }
    Console.Write(num);
    return num * Factorial(num-1);
}
System.Console.WriteLine(Factorial(6)); 




