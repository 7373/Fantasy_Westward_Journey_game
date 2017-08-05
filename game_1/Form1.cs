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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 game_1 = new Form2();
            game_1.Show(); // 打开主窗体
                           //this.Close(); // 关掉自身

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 game_2 = new Form3();
            game_2.Show(); // 打开主窗体
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 game_3 = new Form4();
            game_3.Show(); // 打开主窗体
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

