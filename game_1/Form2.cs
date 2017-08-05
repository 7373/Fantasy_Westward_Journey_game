using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_1
{
    public partial class Form2 : Form
    {
        private uint count = 2;//记录回合数
        private Role rl_1;
        private Enemy em_1;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
            rl_1 = new Role(20000, 3000, 5000, 3000);
            em_1 = new Enemy(30000, 3000, 4500, 300);
            label1.Text = "血量:" + rl_1.Hp.ToString("f1") + "\n" +
                            "攻击力：" + rl_1.Atk.ToString() + "\n" +
                           "防御力:" + rl_1.Def.ToString();

            label2.Text = "血量:" + em_1.Hp.ToString("f1") + "\n" +
                            "攻击力：" + em_1.Atk.ToString() + "\n" +
                           "防御力:" + em_1.Def.ToString();

            label3.Text = "第1回合";


        }

        private void 攻击_Click(object sender, EventArgs e)
        {

            {

                for (int x = 12; x < 200; x += 10)
                {
                    this.pictureBox2.Location = new System.Drawing.Point(x, 130);
                    System.Threading.Thread.Sleep(1);

                    Application.DoEvents();

                }
                for (int n = 410; n > 222; n -= 10)
                {
                    this.pictureBox1.Location = new System.Drawing.Point(n, 130);
                    System.Threading.Thread.Sleep(1);

                    Application.DoEvents();

                }


                this.pictureBox1.Location = new System.Drawing.Point(410, 130);
                this.pictureBox2.Location = new System.Drawing.Point(12, 130);
                em_1.being_Atk(rl_1.Atk, 1);
                rl_1.being_Atk(em_1.Atk, 1);
                if (rl_1.Hp<=0)
                {
                    defeat game_1 = new defeat();
                    game_1.Show(); // 打开主窗体
                     this.Close(); // 关掉自身

                }
                else if (em_1.Hp<=0)
                {
                    victory game_1 = new victory();
                    game_1.Show(); // 打开主窗体
                    this.Close(); // 关掉自身


                }
                label1.Text = "血量:" + rl_1.Hp.ToString("f1") + "\n" +
                                "攻击力：" + rl_1.Atk.ToString() + "\n" +
                               "防御力:" + rl_1.Def.ToString();

                label2.Text = "血量:" + em_1.Hp.ToString("f1") + "\n" +
                                "攻击力：" + em_1.Atk.ToString() + "\n" +
                               "防御力:" + em_1.Def.ToString();
                label3.Text = "第" + count + "回合";

            }
            count++;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {

                for (int x = 12; x < 200; x += 10)
                {
                    this.pictureBox2.Location = new System.Drawing.Point(x, 130);
                    System.Threading.Thread.Sleep(1);

                    Application.DoEvents();

                }
                for (int n = 410; n > 222; n -= 10)
                {
                    this.pictureBox1.Location = new System.Drawing.Point(n, 130);
                    System.Threading.Thread.Sleep(1);

                    Application.DoEvents();

                }


                this.pictureBox1.Location = new System.Drawing.Point(410, 130);
                this.pictureBox2.Location = new System.Drawing.Point(12, 130);
                em_1.being_Atk(rl_1.Atk, 2);
                rl_1.being_Atk(em_1.Atk, 1);
                if (rl_1.Hp <= 0)
                {
                    defeat game_1 = new defeat();
                    game_1.Show(); // 打开主窗体
                    this.Close(); // 关掉自身

                }
                else if (em_1.Hp <= 0)
                {
                    victory game_1 = new victory();
                    game_1.Show(); // 打开主窗体
                    this.Close(); // 关掉自身


                }
                label1.Text = "血量:" + rl_1.Hp.ToString("f1") + "\n" +
                                "攻击力：" + rl_1.Atk.ToString() + "\n" +
                               "防御力:" + rl_1.Def.ToString();

                label2.Text = "血量:" + em_1.Hp.ToString("f1") + "\n" +
                                "攻击力：" + em_1.Atk.ToString() + "\n" +
                               "防御力:" + em_1.Def.ToString();
                label3.Text = "第" + count + "回合";

            }
            count++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {

                for (int x = 12; x < 200; x += 10)
                {
                    this.pictureBox2.Location = new System.Drawing.Point(x, 130);
                    System.Threading.Thread.Sleep(1);

                    Application.DoEvents();

                }
                for (int n = 410; n > 222; n -= 10)
                {
                    this.pictureBox1.Location = new System.Drawing.Point(n, 130);
                    System.Threading.Thread.Sleep(1);

                    Application.DoEvents();

                }


                this.pictureBox1.Location = new System.Drawing.Point(410, 130);
                this.pictureBox2.Location = new System.Drawing.Point(12, 130);
                em_1.being_Atk(rl_1.Atk, 3);
                rl_1.being_Atk(em_1.Atk, 1);
                if (rl_1.Hp <= 0)
                {
                    defeat game_1 = new defeat();
                    game_1.Show(); // 打开主窗体
                    this.Close(); // 关掉自身

                }
                else if (em_1.Hp <= 0)
                {
                    victory game_1 = new victory();
                    game_1.Show(); // 打开主窗体
                    this.Close(); // 关掉自身


                }
                label1.Text = "血量:" + rl_1.Hp.ToString("f1") + "\n" +
                                "攻击力：" + rl_1.Atk.ToString() + "\n" +
                               "防御力:" + rl_1.Def.ToString();

                label2.Text = "血量:" + em_1.Hp.ToString("f1") + "\n" +
                                "攻击力：" + em_1.Atk.ToString() + "\n" +
                               "防御力:" + em_1.Def.ToString();
                label3.Text = "第" + count + "回合";

            }
            count++;
        }
    }
}