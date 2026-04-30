namespace Ex_03_08;

static class Program
{
    static void Main(string[] args)
    {
        NetAccount item1 = new NetAccount();
        Console.Write("口座番号を入力してください->");
        item1.AccountNo = Console.ReadLine();
        Console.Write("口座名義を入力してください->");
        item1.AccountName = Console.ReadLine();
        Console.Write("残高を入力してください->");
        item1.Balance = int.Parse(Console.ReadLine());
        Console.Write("ポイントを入力してください->");
        item1.Point = int.Parse(Console.ReadLine());

        Console.WriteLine($"口座番号：{item1.AccountNo}");
        Console.WriteLine($"口座名義：{item1.AccountName}");
        Console.WriteLine($"残高：{item1.Balance}");
        Console.WriteLine($"ポイント：{item1.Point}");

        item1.Print();
    }
}
