using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiagnosticsEngine
{
    public partial class auth : Form
    {
        public auth()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        bool logged = false;


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "operator" && textBox2.Text == "operator")
            {
                Form1 form1 = new Form1();
                form1.Show();
                logged = true;
                Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void auth_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!logged)
            {
                Application.Exit();
            }
        }
    }
}
