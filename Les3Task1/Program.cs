
double CalculateFormula(int a, int b, int c, int d)
{
    double numerator = a * b;
    int denomenator = c + d;
    double rez = numerator / denomenator;
    return rez;
}

double rezult = CalculateFormula(1, 2, 3, 4);
Console.WriteLine(rezult);
