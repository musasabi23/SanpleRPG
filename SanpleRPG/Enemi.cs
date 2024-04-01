using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanpleRPG
{
    //問題4-1
    internal class Enemi
    {
        public int hp;

        void Attack()
        {
            Console.WriteLine("敵の攻撃！");
        }

        void Escape()
        {
            Console.WriteLine("逃げられた！");
        }
    }
}
