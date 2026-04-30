using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_09
{
    public class Account
    {
        public string? AccountNo { get; set; }  ///口座番号を表すプロパティ
        public string? AccountName { get; set; }    ///口座名義を表すプロパティ
        public int Balance { get; set; }	///残高を表すプロパティ   

        public Account(string AccountNo, string AccountName, int Balance)
        {
            this.AccountNo = AccountNo;
            this.AccountName = AccountName;
            this.Balance = Balance;
        }
        public virtual void Print()
        {
            Console.WriteLine($"商品番号={AccountNo}");
            Console.WriteLine($"商品名={AccountName}");
            Console.WriteLine($"単価={Balance}");
        }

        /// <summary>
        /// objectクラスのToString()メソッドをオーバーライドし、プロパティの値の文字列を返却するメソッド
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Account[AccountNo={AccountNo},AccountName={AccountName},Balance ={Balance}]";
        }
    }

}