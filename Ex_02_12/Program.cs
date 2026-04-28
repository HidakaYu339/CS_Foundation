namespace Ex_02_12;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("値を入力してください⇒");
        int inputnum = int.Parse(Console.ReadLine());
        Console.WriteLine(Mul3(inputnum));

        int Mul3(int num)
        {
            return num * 4;
        }
    }
}
