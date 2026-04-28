namespace Ex_02_05;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("数値を入力してください->");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0) ;
        {
            Console.WriteLine($"結果：{number * 10}");
        }
        Console.WriteLine($"結果：{number}");


    }
}
