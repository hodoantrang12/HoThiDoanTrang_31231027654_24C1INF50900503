using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Session_07_page_33
{ 
    static void Main(string[] args)
    {
        // Initializing data
        var groups = InitializeGroups();

        // Main menu loop
        while (true)
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Print list of all members");
            Console.WriteLine("2. Print member information by ID");
            Console.WriteLine("3. Print the member with the highest completed tasks");
            Console.WriteLine("4. Exit");
            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PrintAllMembers(groups);
                    break;
                case "2":
                    Console.Write("Enter member ID: ");
                    int id = int.Parse(Console.ReadLine());
                    PrintMemberInfo(groups, id);
                    break;
                case "3":
                    PrintTopPerformer(groups);
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }

    // Initialize an array with pre-assigned values
    static Tuple<int, string, int>[][] InitializeGroups()
    {
        return new Tuple<int, string, int>[][]
        {
            // Group 1: 5 members
            new Tuple<int, string, int>[]
            {
                Tuple.Create(101, "Alice Smith", 20),
                Tuple.Create(102, "Bob Johnson", 15),
                Tuple.Create(103, "Charlie Davis", 18),
                Tuple.Create(104, "David Harris", 22),
                Tuple.Create(105, "Eve Williams", 17)
            },
            // Group 2: 3 members
            new Tuple<int, string, int>[]
            {
                Tuple.Create(201, "Frank Brown", 25),
                Tuple.Create(202, "Grace Clark", 19),
                Tuple.Create(203, "Henry Martinez", 21)
            },
            // Group 3: 6 members
            new Tuple<int, string, int>[]
            {
                Tuple.Create(301, "Isabella Taylor", 30),
                Tuple.Create(302, "Jack Moore", 14),
                Tuple.Create(303, "Kathy Anderson", 28),
                Tuple.Create(304, "Louis Thomas", 12),
                Tuple.Create(305, "Mia Jackson", 26),
                Tuple.Create(306, "Nick White", 29)
            }
        };
    }

    // Print list of all members
    static void PrintAllMembers(Tuple<int, string, int>[][] groups)
    {
        Console.WriteLine("\nList of all members:");
        foreach (var group in groups)
        {
            foreach (var member in group)
            {
                Console.WriteLine($"ID: {member.Item1}, Name: {member.Item2}, Completed Tasks: {member.Item3}");
            }
        }
    }

    // Print member information by ID
    static void PrintMemberInfo(Tuple<int, string, int>[][] groups, int id)
    {
        foreach (var group in groups)
        {
            foreach (var member in group)
            {
                if (member.Item1 == id)
                {
                    Console.WriteLine($"\nMember found: ID: {member.Item1}, Name: {member.Item2}, Completed Tasks: {member.Item3}");
                    return;
                }
            }
        }
        Console.WriteLine("Member with ID not found.");
    }

    // Print the member with the highest number of completed tasks
    static void PrintTopPerformer(Tuple<int, string, int>[][] groups)
    {
        Tuple<int, string, int> topPerformer = null;
        foreach (var group in groups)
        {
            foreach (var member in group)
            {
                if (topPerformer == null || member.Item3 > topPerformer.Item3)
                {
                    topPerformer = member;
                }
            }
        }

        if (topPerformer != null)
        {
            Console.WriteLine($"\nTop performer: ID: {topPerformer.Item1}, Name: {topPerformer.Item2}, Completed Tasks: {topPerformer.Item3}");
        }
        else
        {
            Console.WriteLine("No members found.");
        }
    }
}