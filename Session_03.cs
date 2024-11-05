internal class Session_03
{
    private static void Main(string[] args)
    {
        Question_01();
        Question_02();
        Question_03();
    }

    public static void Question_01()
    {
        // Thay đổi mã hóa để hỗ trợ Unicode
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập số độ C cần chuyển đổi: ");
        double celsius = double.Parse(Console.ReadLine());

        // Chuyển đổi từ Celsius sang Kelvin và Fahrenheit
        double kelvin = celsius + 273;
        double fahrenheit = celsius * 18 / 10 + 32;

        // Hiển thị kết quả
        Console.WriteLine($"kelvin= {kelvin}");
        Console.WriteLine($"fahrenheit= {fahrenheit}");
    }

    public static void Question_02()
    {
        // Thay đổi mã hóa để hỗ trợ Unicode
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập bán kính của hình cầu: ");
        double radius = double.Parse(Console.ReadLine());

        // Hằng số Pi
        double pi = Math.PI;

        // Tính diện tích bề mặt
        double surface = 4 * pi * Math.Pow(radius, 2);

        // Tính thể tích
        double volume = (4.0 / 3.0) * pi * Math.Pow(radius, 3);

        // Hiển thị kết quả
        Console.WriteLine($"Surface: {surface:F2}");  // Hiển thị với 2 chữ số thập phân
        Console.WriteLine($"Volume: {volume:F1}");    // Hiển thị với 1 chữ số thập phân
    }

    public static void Question_03()
    {
        // Thay đổi mã hóa để hỗ trợ Unicode
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập số thứ nhất: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Nhập số thứ hai: ");
        int num2 = int.Parse(Console.ReadLine());

        // Thực hiện các phép tính
        int sum = num1 + num2;
        int difference = num1 - num2;
        int product = num1 * num2;
        int quotient = num1 / num2;  // Chia
        int remainder = num1 % num2; // Chia lấy dư

        // Hiển thị kết quả
        Console.WriteLine($"{num1} + {num2} = {sum}");
        Console.WriteLine($"{num1} - {num2} = {difference}");
        Console.WriteLine($"{num1} x {num2} = {product}");
        Console.WriteLine($"{num1} / {num2} = {quotient}");
        Console.WriteLine($"{num1} mod {num2} = {remainder}");
    }
}