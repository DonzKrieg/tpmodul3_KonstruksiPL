using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_103022330150
{
    public partial class SignIn: Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void labelForm_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string inputText = input.Text;
            output.Text = "Halo, Selamat Datang Kembali " + inputText;
        }
    }
}
