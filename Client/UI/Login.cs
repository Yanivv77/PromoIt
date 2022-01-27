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
using DataBaseAccessor;

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

        

        private async void button1_Click(object sender, EventArgs e)
        {
            List<string> user = await _apiAccessor.SendAsyncUser(textBox_Username.Text, textBox_Password.Text);

            string username = user[0];
            string password = user[1];
            dataGridView.DataSource = Users.GetTypeInDataTable(username);


            string typeCheck = dataGridView.CurrentRow.Cells[3].Value.ToString();
            string passCheck = dataGridView.CurrentRow.Cells[1].Value.ToString();
            textBox1.Text = username + " " + password + " " + typeCheck;


            if (password == passCheck)
            {

                switch (typeCheck)
                {
                    case "Activist":
                        SocialActivistsForm Activistform = new SocialActivistsForm(username);
                        this.Hide();
                        Activistform.Show();
                        break;

                    case "NonProfit":
                        NonProfitOrganizationForm NonProfitform = new NonProfitOrganizationForm(username);
                        this.Hide();
                        NonProfitform.Show();
                        break;
                       

                    case "Business":
                        BusinessCompanyForm Businssform = new BusinessCompanyForm(username);
                        this.Hide();
                        Businssform.Show();
                        break;

                    case "Admin":
                        ProLobbyOwnerForm Adminform = new ProLobbyOwnerForm(username);
                        this.Hide();
                        Adminform.Show();
                        break;


                    default:
                        MessageBox.Show("worng input type");
                        break;
                }


            }
            else
            {
                MessageBox.Show("worng input password");
            }



        }
    }
}
