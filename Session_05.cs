internal class Functions
{
    public static void swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    public static void Main(string[] args)
    {
        int a = 6, b = 7;
        Console.WriteLine($"Before call a={a}, b={b}");
        swap(ref a, ref b);
        Console.WriteLine($"After call a={a}, b={b}");

    }
}