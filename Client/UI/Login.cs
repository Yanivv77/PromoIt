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
#pragma warning disable CS8604 // Possible null reference argument.
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
           // var isSueedded = await _apiAccessor.SendAsync(textBox_Username.Text, textBox_Password.Text);
            //MessageBox.Show(isSueedded ? "logged in successfully" : "Error sending message", "Result", MessageBoxButtons.OK, isSueedded ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            List<string> user = await _apiAccessor.SendUser(textBox_Username.Text, textBox_Password.Text);

            string username = user[0];
            string password = user[1];
            dataGridView.DataSource = Users.GetTypeInDataTable(username);


            
            string passCheck = dataGridView.CurrentRow.Cells[1].Value.ToString();
            string Type = dataGridView.CurrentRow.Cells[3].Value.ToString();
            string Id = dataGridView.CurrentRow.Cells[0].Value.ToString();

            if (password == passCheck)
            {

                switch (Type)
                {
                    case "Activist":

                        SocialActivistsForm Activistform = new SocialActivistsForm(username, int.Parse(Id));

                        this.Hide();
                        Activistform.Show();
                        break;

                    case "NonProfit":
                        NonProfitOrganizationForm NonProfitform = new NonProfitOrganizationForm(username, int.Parse(Id));
                        this.Hide();
                        NonProfitform.Show();
                        break;


                    case "Business":
                        BusinessCompanyForm Businssform = new BusinessCompanyForm(username, int.Parse(Id));
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