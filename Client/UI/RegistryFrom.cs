using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBaseAccessor;


namespace UI
{
    public partial class RegistryFrom : Form
    {
        public RegistryFrom()
        {
            InitializeComponent();
        }

        private void button_Activist_Click(object sender, EventArgs e)
        {
            panel_Activist.BringToFront();
            panel_ActivistBar.BackColor = Color.Yellow;
            panel_BusinessBar.BackColor = Color.FromArgb(44, 44, 44);
            panel_NonProfitBar.BackColor = Color.FromArgb(44, 44, 44);
            button_NonProfit.BackColor = Color.Black;
            button_Business.BackColor = Color.Black;
            button_Activist.BackColor = Color.FromArgb(84, 84, 84);

        }

        private void button_NonProfit_Click(object sender, EventArgs e)
        {
            panel_NonProfit.BringToFront();
            panel_NonProfitBar.BackColor = Color.Yellow;
            panel_ActivistBar.BackColor = Color.FromArgb(44, 44, 44);
            panel_BusinessBar.BackColor = Color.FromArgb(44, 44, 44);
            button_Activist.BackColor = Color.Black;
            button_Business.BackColor = Color.Black;
            button_NonProfit.BackColor = Color.FromArgb(84, 84, 84);
        }

        private void button_Business_Click(object sender, EventArgs e)
        {
            panel_Business.BringToFront();
            panel_BusinessBar.BackColor = Color.Yellow;
            panel_NonProfitBar.BackColor = Color.FromArgb(44, 44, 44);
            panel_ActivistBar.BackColor = Color.FromArgb(44, 44, 44);
            button_NonProfit.BackColor = Color.Black;
            button_Activist.BackColor = Color.Black;
            button_Business.BackColor = Color.FromArgb(84, 84, 84);
        }


        private void button_Back_Click(object sender, EventArgs e)
        {
            Login frm2 = new Login();
            this.Hide();
            frm2.Show();
            
        }

        private void button_ASignIn_Click(object sender, EventArgs e)
        {
            Users.AddActivist(textBox_AUsername.Text, textBox_APassword.Text, "Activist", textBox_AEmail.Text,
          textBox_Adress.Text, textBox_APhone.Text, textBox_ATwitter.Text);

            Login frm2 = new Login();
            this.Hide();
            frm2.Show();
        }

        private void button_NSignIn_Click(object sender, EventArgs e)
        {
            Users.AddNonProfit(textBox_NUsername.Text, textBox_NPassword.Text, "NonProfit", textBox_NName.Text,
                textBox_NEmail.Text, textBox_NWebsite.Text);

            Login frm2 = new Login();
            this.Hide();
            frm2.Show();
        }


        private void button_BSignIn_Click(object sender, EventArgs e)
        {
            Users.AddBusiness(textBox_BUsername.Text, textBox_BPassword.Text, "Business", textBox_BName.Text);

            Login frm2 = new Login();
            this.Hide();
            frm2.Show();

        }

        












        //private void button_GoToLogin_Click(object sender, EventArgs e)
        //{
        //    panel_login.BringToFront();
        //    panel_login_bar.BackColor = Color.Yellow;
        //    panel_register_bar.BackColor = select_color;
        //    button_GoToLogin.BackColor = select_color;
        //    button_GoToRegister.BackColor = Color.Black;
        //}


    }
}
