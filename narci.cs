public class Narcissistic
{
    public Narcissistic()
    {
        for (var i = 0; i < 1000000; i++)
            if (IsNarci(i)) Console.WriteLine("Narcissistic: " + i);

        Console.WriteLine("End.");
        Console.ReadKey();
    }

    private static bool IsNarci(double n)
    {
        var ns = n.ToString(CultureInfo.InvariantCulture).ToArray();

        var prove = ns.Sum(x => Math.Pow((x - 48), ns.Length));

        return prove == n;
    }
}
