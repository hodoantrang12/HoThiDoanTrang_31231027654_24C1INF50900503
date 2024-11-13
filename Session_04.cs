using System.ComponentModel;

internal class Control_flow
{
    static void Session04_mau()
{
    do
    {
        // 1. Máy nghĩ ngẫu nhiên 1 số
        Random rnd = new Random();
        int comp_num = rnd.Next(0, 10) + 1; // Lệnh next(0, 10) chỉ lấy từ 0 đến 9, cộng 1 để lấy đúng giá trị 
                                            //2. keu nguoi dung dua 1 so
                                            // doan den khi dung
        int count = 0;
        bool isContinue = true;
        do
        {
            count++;
            Console.Write("Bạn đoán số mấy? <1..10>: ");
            int user_num = int.Parse(Console.ReadLine());

            // 3. Kiểm tra kết quả
            if (user_num == comp_num)
            {
                Console.WriteLine($"Bạn đã đoán trúng sau {count} lần :)");
                isContinue = false;
            }
            else
            {
                if (user_num > comp_num)
                    Console.WriteLine("Số bạn nhập lớn hơn số máy nghĩ.");
                else
                    Console.WriteLine("Số bạn nhập bé hơn số máy nghĩ.");
            }
        } while (isContinue);

        Console.WriteLine("_______________________");
        Console.WriteLine("Chơi nữa hoặc C/K >> ");
        string tl = Console.ReadLine();
        if (tl.ToUpper().Equals("K"))
        {
            Console.WriteLine("Thắng mà không cho gỡ. Lần sau không chơi nữa!");
            return;
        }
    } while (true);
}
    static void Main()
    {
        //Ex_01();
        //Ex_02();
        //Ex_03();
        //Ex_04();
        Ex_05();
    }

    static void Ex_01()
    {
        // Thay đổi mã hóa để hỗ trợ Unicode
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập một số nguyên: ");
        int number = int.Parse(Console.ReadLine());

        // Kiểm tra số đó là chẵn hay lẻ
        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} là số chẵn.");
        }
        else
        {
            Console.WriteLine($"{number} là số lẻ.");
        }
    }

    static void Ex_02()
    {
        // Thay đổi mã hóa để hỗ trợ Unicode
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Nhập ba số từ người dùng
        Console.Write("Nhập số thứ nhất: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Nhập số thứ hai: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Nhập số thứ ba: ");
        int num3 = int.Parse(Console.ReadLine());

        // Biến để lưu trữ số lớn nhất
        int largest;

        // Sử dụng if-else để tìm số lớn nhất
        if (num1 >= num2 && num1 >= num3)
        {
            largest = num1;
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            largest = num2;
        }
        else
        {
            largest = num3;
        }

        // Hiển thị số lớn nhất
        Console.WriteLine("Số lớn nhất là: " + largest);
    }

    static void Ex_03()
    {
        // Thay đổi mã hóa để hỗ trợ Unicode
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Nhập giá trị tọa độ X
        Console.Write("Nhập giá trị tọa độ X: ");
        int x = int.Parse(Console.ReadLine());

        // Nhập giá trị tọa độ Y
        Console.Write("Nhập giá trị tọa độ Y: ");
        int y = int.Parse(Console.ReadLine());

        // Kiểm tra góc phần tư
        if (x > 0 && y > 0)
        {
            Console.WriteLine($"Điểm tọa độ ({x}, {y}) nằm trong góc phần tư thứ nhất.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine($"Điểm tọa độ ({x}, {y}) nằm trong góc phần tư thứ hai.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine($"Điểm tọa độ ({x}, {y}) nằm trong góc phần tư thứ ba.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine($"Điểm tọa độ ({x}, {y}) nằm trong góc phần tư thứ tư.");
        }
        else if (x == 0 && y == 0)
        {
            Console.WriteLine("Điểm tọa độ (0, 0) nằm tại gốc tọa độ.");
        }
        else if (x == 0)
        {
            Console.WriteLine($"Điểm tọa độ ({x}, {y}) nằm trên trục Y.");
        }
        else if (y == 0)
        {
            Console.WriteLine($"Điểm tọa độ ({x}, {y}) nằm trên trục X.");
        }
    }

    static void Ex_04()
    {
        // Thay đổi mã hóa để hỗ trợ Unicode
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Nhập độ dài ba cạnh của tam giác
        Console.Write("Nhập độ dài cạnh thứ nhất: ");
        int side1 = int.Parse(Console.ReadLine());

        Console.Write("Nhập độ dài cạnh thứ hai: ");
        int side2 = int.Parse(Console.ReadLine());

        Console.Write("Nhập độ dài cạnh thứ ba: ");
        int side3 = int.Parse(Console.ReadLine());

        // Kiểm tra nếu ba cạnh có tạo thành một tam giác không
        if (side1 <= 0 || side2 <= 0 || side3 <= 0)
        {
            Console.WriteLine("Ba cạnh không hợp lệ để tạo thành tam giác.");
        }
        else if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
        {
            // Kiểm tra loại tam giác
            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("Tam giác là tam giác đều (Equilateral).");
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                Console.WriteLine("Tam giác là tam giác cân (Isosceles).");
            }
            else
            {
                Console.WriteLine("Tam giác là tam giác thường (Scalene).");
            }
        }
        else
        {
            Console.WriteLine("Ba cạnh không hợp lệ để tạo thành tam giác.");
        }
    }

    static void Ex_05()
    {
        // Thay đổi mã hóa để hỗ trợ Unicode
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Khai báo biến để lưu tổng và số lượng
        int sum = 0;
        int count = 10;

        // Vòng lặp để nhập 10 số
        for (int i = 1; i <= count; i++)
        {
            Console.Write($"Nhập số thứ {i}: ");
            int number = int.Parse(Console.ReadLine());

            // Cộng giá trị của số vào tổng
            sum += number;
        }

        // Tính trung bình
        double average = (double)sum / count;

        // Hiển thị kết quả
        Console.WriteLine($"Tổng của 10 số là: {sum}");
        Console.WriteLine($"Trung bình của 10 số là: {average}");
    }
}
