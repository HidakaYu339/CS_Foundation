using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_04_03.Modules
{
    public class Employee
    {
        public int Id { get; set; } //社員番号を表すプロパティ
        public string? Name { get; set; }  //名前を表すプロパティ
        public string? Address { get; set; }    //住所を表すプロパティ
        public Employee(int id, string name, string address)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
        } //引数の値をプロパティに設定       
        public override string ToString()//3-9にオーバーライド
        {
            return $"Employee [ id = {Id},name = {Name},address = {Address}]";
            //return $"Account[AccountNo={AccountNo},AccountName={AccountName},Balance ={Balance}]";
        }
    }
}