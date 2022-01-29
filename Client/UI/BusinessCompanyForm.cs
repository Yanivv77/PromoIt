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
    public partial class BusinessCompanyForm : Form
    {

        private readonly ApiAccessor _apiAccessor = new ApiAccessor();
        public BusinessCompanyForm(string name, int id)
        {
            
            InitializeComponent();
            UserName.Text = name;
            label_ID.Text = id.ToString();
            dataGridView_MyDonations.DataSource = DataBaseAccessor.Shop.DonationsBYBusiness(id);
            dataGridView_ToSend.DataSource = DataBaseAccessor.Shop.OrdersByBusiness(id);
        }

        private async void button_CreateDonation_Click(object sender, EventArgs e)
        {
            List<string> donation = await _apiAccessor.SendDonation(int.Parse(label_ID.Text), richTextBox_Campaign.Text, richTextBox_ProductName.Text, int.Parse(richTextBox_ProductValue.Text), int.Parse(richTextBox_Quantity.Text));
            DataBaseAccessor.Shop.AddProductDonation(donation[0], donation[1], donation[2], int.Parse(donation[3]), int.Parse(donation[4]));


        }

       
    }
}
