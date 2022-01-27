using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Login : Form
    {

        private readonly ApiAccessor _apiAccessor = new ApiAccessor();
        public Login()
        {
            InitializeComponent();
        }

        private void button_NewAccount_Click(object sender, EventArgs e)
        {
            RegistryFrom frm2 = new RegistryFrom();
            this.Hide();
            frm2.Show();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void button_Login_Click(object sender, EventArgs e)
        {
            var s = await _apiAccessor.SendAsyncUsername(textBox_Username.Text, textBox_Password.Text);

            textBox1.Text = s;


        }
    }
}
