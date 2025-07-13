using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recegame
{
    public partial class MainForm : Form
    {
        private Batmobile batmobile = new Batmobile();
        private Beetle beetle = new Beetle();
        private static Random AttackRandom = new Random();
        private static Random SkillRandom = new Random();
        public MainForm()
        {
            InitializeComponent();
            batmobile.Step = 0;
            beetle.Step = 0;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Stop_Button_Click(object sender, EventArgs e)
        {
            
            BatmobileStatus_TextBox.Text = batmobile.Stop();
        }

        private void Start_Botton_Click(object sender, EventArgs e)
        {
            BatmobileStatus_TextBox.Text = batmobile.StartEngine();
            BeetleStatus_TextBox.Text = batmobile.StartEngine();

        }

        private async void gamestart_button_Click(object sender, EventArgs e)
        {
            while (batmobile.Step <= 100 && beetle.Step < 100)
            {
                batmobile.Run();
                beetle.Run();

                BatmobileStatus_TextBox.Text = $"{batmobile.Step}/100";
                BeetleStatus_TextBox.Text = $"{beetle.Step}/100";

                if (SkillRandom.Next(0,2)==0)
                {
                    BatmobileSkill_TextBox.Text = batmobile.SpecialSkill(beetle);
                }
                else
                {
                    BeetleSkill_TextBox.Text = beetle.SpecialSkill(beetle);
                }
                await Task.Delay(1000);  
            }

            if (batmobile.Step >= 100 && beetle.Step < 100)
            {
                MessageBox.Show("蝙蝠車獲勝！", "比賽結果");
            }
            else if (beetle.Step >= 100 && batmobile.Step < 100)
            {
                MessageBox.Show("金龜車獲勝！", "比賽結果");
            }
            else if (batmobile.Step >= 100 && beetle.Step >= 100)
            {
                MessageBox.Show("平手！", "比賽結果");
            }
        }

        private void Attack_button_Click(object sender, EventArgs e)
        {

            int WhoBeAttack = AttackRandom.Next(0, 2); 

            if (WhoBeAttack == 0) 
            {
                
                batmobile.WeakPoint(1);
            }
            else 
            {

                beetle.WeakPoint(1);
            }
        }
    }
}
