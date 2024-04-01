using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanpleRPG
{
    internal class Player
    {
        //list4-1
        public string name; //プレイヤーの名前
        public int hp;

        //攻撃メソッド
        public void Attack()
        {
            Console.WriteLine(this.name + "は攻撃した");
        }

        //防御メソッド
        public void Defense()
        {
            Console.WriteLine(this.name + "は防御した");
        }
    }
}
