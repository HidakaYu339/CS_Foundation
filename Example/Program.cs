namespace Example;

class Program
{
    static void Main(string[] args)
    {
        // インスタンスの生成
        Warrior warrior = new();
        Monster monster = new();
        // フィールドに値を設定
        warrior.name = "ユータ";
        monster.name = "ゴブ";
        // メソッドの利用
        string meter1 = warrior.GetHpMeter();// 初期の戦士のHPを取得
        Console.WriteLine(meter1); // 戦士のHPを表示
        monster.Attack(warrior); // 魔物が戦士に攻撃
        string meter2 = warrior.GetHpMeter();// 攻撃を受けた後の戦士のHPを取得
        Console.WriteLine(meter2); // 戦士のHPを表示
    }
}

