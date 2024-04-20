// See https://aka.ms/new-console-template for more information

class TestGit
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите приветствие");
        string hello = Console.ReadLine();
        Console.WriteLine("");

        Print(hello);


        void Print(string s)
        { 
            Console.WriteLine(s); 
        }
    }
}
