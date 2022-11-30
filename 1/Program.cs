// f(x) =  1*x^0 + 2*x^1 + 0*x^2 + 4*x^3 + 5*x^4+ 16*x^5
// g(x) =  10*x^0 + 11*x^1 + 4*x^2 

// Метод подсчета суммы многочленов

int[] Sum(int[] f, int[] g)
{
    int powF = f.Length;
    int powG = g.Length;

    int resultMax = powF;
    int resultMin = powG;

    if (powG > resultMax)
    {
        resultMax = powG;
        resultMin = powF;
    }

    int[] result = new int[resultMax];

    for (int i = 0; i < resultMin; i++)
    {
        result[i] = f[i] + g[i];
    }

    for (int i = resultMin; i < resultMax; i++)
    {
        if (resultMax == powG) result[i] = g[i];
        else result[i] = f[i];
    }

    return result;
}

// Метод подсчета разницы многочленов

int[] Dif(int[] f, int[] g)
{
    int powF = f.Length;
    int powG = g.Length;

    int resultMax = powF;
    int resultMin = powG;

    if (powG > resultMax)
    {
        resultMax = powG;
        resultMin = powF;
    }

    int[] result = new int[resultMax];

    for (int i = 0; i < resultMin; i++)
    {
        result[i] = f[i] - g[i];
    }

    for (int i = resultMin; i < resultMax; i++)
    {
        if (resultMax == powG) result[i] = -g[i];
        else result[i] = f[i];
    }

    return result;
}

// Метод вывода элементов многочлена на экран

string Print(int[] f)
{
    string[] pows = { "^0", "^1", "^2", "^3", "^4", "^5", "^6", "^7", "^8", "^9" };
    string output = String.Empty;
    for (int i = 0; i < f.Length; i++)
    {
        int t = f[i];
        if (f[i] == 0) continue;
        if (f[i] < 0) { output += " - "; }
        else if (i != 0) { output += " + "; }

        if (t < 0) t = -t;
        if (i == 1) { output += $"{t}x"; }
        if (i == 0) { output += $"{t}"; }
        if (i != 1 && i != 0 && f[i] != 0) { output += $"{t}x{pows[i]}"; }
       
    }

    return output;
}

int[] f = { -3, 5, 0, 1, 34, -6 };
int[] g = { 0, -1, 2, 0, 0, 3, 2 };
int[] s = Sum(f, g);
int[] d = Dif(f, g);
Console.WriteLine($"f(x) = {Print(f)}");
Console.WriteLine($"g(x) = {Print(g)}");
System.Console.WriteLine();
Console.WriteLine($"f(x) + g(x) = {Print(s)}");
Console.WriteLine($"f(x) - g(x) = {Print(d)}");
