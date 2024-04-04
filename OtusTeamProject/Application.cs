
namespace OtusTeamProject;

public static class Application
{
    public static void Main()
    {
        Console.WriteLine("Hello, Otus!");
        Console.WriteLine();
        
        //Дима
        Console.WriteLine((0.1 + 0.2).ToString());

        //Паша
        Console.WriteLine(DateTime.Now.ToString("d"));

        //Костя
        var kosty = "Костя Ливчак тута =)";
        Console.WriteLine(kosty);

        Console.ReadKey();
    }
}