internal class Exercises_01
{
    private static void Main(string[] args)
    {
        Question_01();
        Question_02();
        Question_03();
        Question_04();
    }

    public static void Question_01()
    {
        Console.WriteLine("Nhap so a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap so b: ");
        int b = int.Parse(Console.ReadLine());
        int c = a + b;

        Console.WriteLine($"{a} + {b} = {c}");
    }

    public static void Question_02()
    {
        Console.Write("Enter the first value: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second value: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nBefore Swapping:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

        // Swap the values
        int temp = a;
        a = b;
        b = temp;

        // Display values after swapping
        Console.WriteLine("\nAfter Swapping:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }

    public static void Question_03()
    {
        Console.Write("Enter the first floating-point number: ");
        float num1 = Convert.ToSingle(Console.ReadLine());

        Console.Write("Enter the second floating-point number: ");
        float num2 = Convert.ToSingle(Console.ReadLine());

        float result = num1 * num2;
        Console.WriteLine("The result is {2}", num1, num2, result);
    }

    public static void Question_04()
    {
        Console.Write("Enter number of feet: ");
        double feet = Convert.ToDouble(Console.ReadLine());
        double meters = feet * 0.3048;
        Console.WriteLine("{0} feet is equal to {1} meters.", feet, meters);
    }

    public static void Question_05()
    {
       
    }
}