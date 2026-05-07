using System.Data;

namespace Ex_04_02;

static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("年を入力してください->");
        int year = int.Parse(Console.ReadLine());
        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine($"{year}年は閏年です。");//true処理
        }
        else
        {
            Console.WriteLine($"{year}年は閏年ではありません。");//false処理
        }
    }
}
