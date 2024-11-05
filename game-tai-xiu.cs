class Game_TaiXiu
{
    static int rollDice()
    {
        Random rnd = new Random();
        int die_1 = rnd.Next(6) + 1;
        int die_2 = rnd.Next(6) + 1;
        int die_3 = rnd.Next(6) + 1;
        int sum_of_dice = die_1 + die_2 + die_3;
        return sum_of_dice;
    }
    static void playOneRound()
    {
        int com_dice = rollDice();
        Console.Write("Ban doan Tai hay Xiu <T/X>");
        string user_guessing = Console.ReadLine();
        if (user_guessing.ToUpper().Equals("T"))
        {
            if (com_dice >= 10)//tài
                Console.WriteLine("Ban thang");
            else
                Console.WriteLine("ban thua");
        }
        else if (user_guessing.ToUpper().Equals("X"))
        {
            if (com_dice < 10)//xiu
                Console.WriteLine("Ban thang");
            else
                Console.WriteLine("ban thua");
        }
        else
        {
            Console.WriteLine("Vui long chon cho dung");
        }
    }
    static void game_engine()
    {
        do
        {
            playOneRound();

            Console.Write("Ban choi nua khong? <C/K>");
            string choice = Console.ReadLine();
            if (choice.ToUpper().Equals("K"))
                break;
        } while (true);
        Console.WriteLine("Mai choi nua nhe!");
    }

    public static void Main()
    {
        game_engine();
    }
}


class Game_TaiXiu
{
    static Random rnd = new Random();
    static int user_balance = 1000000;  // Số tiền khởi điểm của người chơi
    static int total_rounds = 0;  // Tổng số ván chơi
    static int wins = 0;  // Số ván thắng
    static int losses = 0;  // Số ván thua

    static int rollDice2()
    {
        int die_1 = rnd.Next(1, 7);
        int die_2 = rnd.Next(1, 7);
        int die_3 = rnd.Next(1, 7);
        return die_1 + die_2 + die_3;
    }

    static void playOneRound()
    {
        Console.WriteLine($"Số tiền hiện tại của bạn: {user_balance} đồng");

        // Người chơi đặt cược
        Console.Write("Nhập số tiền cược: ");
        int bet = int.Parse(Console.ReadLine());

        // Kiểm tra nếu tiền cược hợp lệ
        if (bet > user_balance || bet <= 0)
        {
            Console.WriteLine("Số tiền cược không hợp lệ. Vui lòng nhập lại.");
            return;
        }

        total_rounds++;
        int com_dice = rollDice();
        Console.Write("Bạn đoán Tài hay Xỉu <T/X>: ");
        string user_guessing = Console.ReadLine();

        bool user_won = false;

        if (user_guessing.ToUpper().Equals("T"))
        {
            if (com_dice >= 10) // Tài
            {
                Console.WriteLine("Bạn thắng!");
                user_won = true;
            }
            else
            {
                Console.WriteLine("Bạn thua!");
                user_won = false;
            }
        }
        else if (user_guessing.ToUpper().Equals("X"))
        {
            if (com_dice < 10) // Xỉu
            {
                Console.WriteLine("Bạn thắng!");
                user_won = true;
            }
            else
            {
                Console.WriteLine("Bạn thua!");
                user_won = false;
            }
        }
        else
        {
            Console.WriteLine("Vui lòng chọn đúng.");
            return;
        }

        // Cập nhật tiền
        if (user_won)
        {
            user_balance += bet;
            wins++;
        }
        else
        {
            user_balance -= bet;
            losses++;
        }
    }

    static void game_engine()
    {
        while (user_balance > 0)
        {
            playOneRound();

            // Kiểm tra nếu người chơi hết tiền
            if (user_balance <= 0)
            {
                Console.WriteLine("Bạn đã hết tiền! Trò chơi kết thúc.");
                break;
            }

            Console.Write("Bạn có muốn chơi tiếp không? <C/K>: ");
            string choice = Console.ReadLine();
            if (choice.ToUpper().Equals("K"))
                break;
        }

        // Hiển thị thống kê sau khi kết thúc trò chơi
        Console.WriteLine("Thống kê sau khi chơi:");
        Console.WriteLine($"Số ván đã chơi: {total_rounds}");
        Console.WriteLine($"Số ván thắng: {wins}");
        Console.WriteLine($"Số ván thua: {losses}");
        Console.WriteLine($"Số tiền còn lại: {user_balance} đồng");
    }

    public static void Main()
    {
        game_engine();
    }
}
