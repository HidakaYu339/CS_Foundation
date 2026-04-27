namespace Ex_02_02;

static class Program
{
    static void Main(string[] args)
    {
        // 数値の演算
        Console.WriteLine($"10 + 3 = {10 + 3}");
        Console.WriteLine($"10 - 3 = {10 - 3}");
        Console.WriteLine($"10 * 3 = {10 * 3}");
        Console.WriteLine($"10 / 3 = {10 / 3}");
        Console.WriteLine($"10 % 3 = {10 % 3}");
        // 文字列の連結
        Console.WriteLine($"ABC + XYZ = {"ABC" + "XYZ"}");
        // 文字列と他のデータ型の結合
        Console.WriteLine($"ABC + 1 = {"ABC" + 1}");
        // その他、文字列の結合と表示（参考）
        Console.WriteLine($"ABC + 2 = {"ABC"}{2}");
        Console.WriteLine("ABC + 3 = {0}{1}", "ABC", 3);
    }
}
