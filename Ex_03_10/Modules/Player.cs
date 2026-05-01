using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_10.Modules
{
    public abstract class Player
    {
        ///private string media; フィールド
        public string Media { get; }///再生するメディアを表す自動プロパティ

        public Player(string Media)///引数の値でMediaプロパティを初期化する
        {
            this.Media = Media;
        }
        public abstract void Play();///メディアを再生中であることを出力する

        public abstract void Stop();///メディアの再生を停止したことを出力する

    }
}

