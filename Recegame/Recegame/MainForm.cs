using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recegame
{
    public partial class MainForm : Form
    {
        private Car mycar = new Car();
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Stop_Button_Click(object sender, EventArgs e)
        {
            
            Status_TextBox.Text = mycar.Stop();
        }

        private void Start_Botton_Click(object sender, EventArgs e)
        {
            Status_TextBox.Text = mycar.StartEngine();
        }
    }
}
