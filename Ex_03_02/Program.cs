namespace Ex_03_02;

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
        item1.Print();
    }
}
