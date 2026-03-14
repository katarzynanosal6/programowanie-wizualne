namespace mojabiblioteka;

public class Kalkulator
{
    public int Dodaj(int a, int b)
    {
        return a + b;
    }

    public int Odejmij(int a, int b)
    {
        return a - b;
    }

    public int Pomnoz(int a, int b)
    {
        return a * b;
    }

    public double Podziel(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Nie można dzielić przez zero.");
        }
        return (double)a / b;
    }
}
