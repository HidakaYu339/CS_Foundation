using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_09
{
    public class NetAccount : Account
    {
        public int Point { get; set; }	///ポイントを表すプロパティ

        public NetAccount(string AccountNo, string AccountName, int Balance, int Point) : base(AccountNo, AccountName, Balance)
        {

        }
    }
}