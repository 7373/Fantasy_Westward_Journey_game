using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_1
{
    class Enemy
    {
        private double hp;//血量
        private double mp;//法力值     
        private double atk;//攻击力
        private double def;//防御力

        public Enemy(double hp, double mp, double atk, double def)
        {
            this.atk = atk;
            this.def = def;
            this.hp = hp;
            this.mp = mp;

        }

        public double Hp
        {
            get
            {
                return hp;
            }

            set
            {
                hp = value;
            }
        }

        public double Mp
        {
            get
            {
                return mp;
            }

            set
            {
                mp = value;
            }
        }

        public double Atk
        {
            get
            {
                return atk;
            }

            set
            {
                atk = value;
            }
        }

        public double Def
        {
            get
            {
                return def;
            }

            set
            {
                def = value;
            }
        }
        public void being_Atk(double atk_2, uint atk_Type)//参数是攻击者的攻击力和攻击类型；
        {
            this.Hp = (this.Hp - (atk_2 * atk_Type - this.Def));//调用SET GET方法操作；放大了攻击力（技能

        }
    }
}
