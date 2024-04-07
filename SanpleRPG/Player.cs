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
        //list4-7
        private string name; //プレイヤーの名前
        private int hp; //プレイヤーの名前

        //list4-3
        //Playerクラスのコンストラクタ
        //list4-5
        public Player(string name, int hp)
        {
            this.name = name;
            this.hp = hp;
        }

        //list4-9
        //list4-11
        //Hpプロパティ
        public int Hp
        {
            set
            {
                this.hp = value;
                if (this.hp < 0)
                {
                    this.hp = 0;
                }
            }
            get
            {
                return this.hp;
            }
        }


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
