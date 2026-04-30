using System.Net.ServerSentEvents;

namespace Ex_03_06;

static class Program
{
    static void Main(string[] args)
    {
        Item item1 = new Item();
        Console.Write("商品番号を入力してください->");
        item1.itemNo = int.Parse(Console.ReadLine());
        Console.Write("商品名を入力してください->");
        item1.itemName = Console.ReadLine();
        Console.Write("単価を入力してください->");
        item1.price = int.Parse(Console.ReadLine());
        Console.Write("新しい単価を入力してください->");
        item1.ChangePrice(int.Parse(Console.ReadLine()));
        Console.WriteLine("結果");
        item1.Print();

        Console.Write("更に新しい単価を入力してください->");
        item1.ChangePrice(Console.ReadLine());              // ポイント
        Console.WriteLine("結果");
        item1.Print();

    }
}
