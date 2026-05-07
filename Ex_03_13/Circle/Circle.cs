using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_13.Circle
{
    public class Circle
    {
        public static double PI = 3.14; //円周率
        int radius;	//半径 

        public double AreaCalculation()//フィールドの半径の値の円の面積を計算する動的メソッド
        {
            return radius * radius * PI;
        }
        public static double AreaCalculation(int radius)//引数の半径の値の円の面積を計算する静的メソッド
        {

        }
        public Circle(int pradius)  //フィールドの半径を初期化するコンストラクタ
        {

        }
    }
}