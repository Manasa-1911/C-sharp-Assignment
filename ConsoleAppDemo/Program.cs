// See https://aka.ms/new-console-template for more information
class Myclass
{
    enum Grade
    {
        Pass = 60, Distinction = 85
    };
    public static void Main()
    {
        int empid;
        int marks;



        Console.WriteLine("Whats your empid?");
        empid = int.Parse(Console.ReadLine());
        Console.WriteLine("Hello, World!");
        Console.WriteLine($"Thanks for giving your empid {empid}");
        Console.WriteLine("Enter your TSQL Marks?");
        marks = Convert.ToInt32(Console.ReadLine());
        if (marks >= (int)Grade.Distinction)
        {
            Console.WriteLine("You are in Distinction grade");
        }
        else if (marks >= (int)Grade.Pass)
        {
            Console.WriteLine("You are in Pass grade");
        }
        else
            Console.WriteLine("Sorry, You are in fail grade");
    }
}

