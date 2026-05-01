

namespace Ex_03_10.Modules
{
    public class BlurayPlayer : Player
    {
        public BlurayPlayer(string Media) : base(Media)///Playerクラスのコンストラクタを呼び出す 

        {

        }
        public override void Play()
        {
            Console.WriteLine("Blu-ray:" + Media + "を再生しています");
        }
        public override void Stop()
        {
            Console.WriteLine("Blu-ray:" + Media + "を停止しました");
        }

    }
}