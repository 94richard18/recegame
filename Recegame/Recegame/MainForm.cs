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

        public MainForm()
        {
            InitializeComponent();
            batmobile.Place = 0;
            beetle.Place = 0;
            
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
        /*
        private void gamestart_button_Click(object sender, EventArgs e)
        {
            do
            {
                batmobile.Place += batmobile.Run();
                beetle.Place += batmobile.Run();
                BatmobileStatus_TextBox.Text = $"{batmobile.Place}/100";
                BeetleStatus_TextBox.Text = $"{beetle.Place}/100";
                System.Threading.Thread.Sleep(1000);
            } while (batmobile.Place<=100 && beetle.Place<100);


        }
        */
        private async void gamestart_button_Click(object sender, EventArgs e)
        {
            while (batmobile.Place <= 100 && beetle.Place < 100)
            {
                batmobile.Place += batmobile.Run();
                beetle.Place += beetle.Run();

                BatmobileStatus_TextBox.Text = $"{batmobile.Place}/100";
                BeetleStatus_TextBox.Text = $"{beetle.Place}/100";

                await Task.Delay(1000);  // 非同步等待1秒，不會卡住 UI 執行緒
            }

            if (batmobile.Place >= 100 && beetle.Place < 100)
            {
                MessageBox.Show("蝙蝠車獲勝！", "比賽結果");
            }
            else if (beetle.Place >= 100 && batmobile.Place < 100)
            {
                MessageBox.Show("金龜車獲勝！", "比賽結果");
            }
            else if (batmobile.Place >= 100 && beetle.Place >= 100)
            {
                MessageBox.Show("平手！兩輛車都到達終點！", "比賽結果");
            }
        }

    }
}
