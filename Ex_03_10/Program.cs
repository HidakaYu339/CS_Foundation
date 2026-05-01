using Ex_03_10.Modules;
namespace Ex_03_10;

static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("DVDのタイトルを入力してください->");
        string DVDtitle = Console.ReadLine();
        Player player1 = new DVDPlayer(DVDtitle);
        player1.Play();
        player1.Stop();

        Console.WriteLine("Blu-rayのタイトルを入力してください->");
        string Blutitle = Console.ReadLine();
        player1 = new BlurayPlayer(Blutitle);
        player1.Play();
        player1.Stop();
    }
}

