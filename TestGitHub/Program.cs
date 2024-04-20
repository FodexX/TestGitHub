// See https://aka.ms/new-console-template for more information

class TestGit
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите приветствие, пж");
        string hello = Console.ReadLine();

        Print(hello);


        void Print(string s)
        { 
            Console.WriteLine(s); 
        }
    }
}
