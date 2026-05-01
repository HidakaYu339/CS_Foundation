using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_10.Modules
{
    public class DVDPlayer : Player
    {
        public DVDPlayer(string Media) : base(Media) ///Playerクラスのコンストラクタを呼び出す
        {

        }
        public override void Play()
        {
            Console.WriteLine("DVD:" + Media + "を再生しています");
        }
        public override void Stop()
        {
            Console.WriteLine("DVD:" + Media + "を停止しました");
        }
    }
}