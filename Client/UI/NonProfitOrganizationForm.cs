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
    public partial class NonProfitOrganizationForm : Form
    {
        private readonly ApiAccessor _apiAccessor = new ApiAccessor();

        public NonProfitOrganizationForm(string name, int id)
        {
            InitializeComponent();
            UserName.Text = name;
            label_ID.Text = id.ToString();
            dataGridView_MyCampaigns.DataSource = DataBaseAccessor.Campaigns.CampaignsByNonProfitIDTable(id);


        }

        private async void button_CreateCampaign_Click(object sender, EventArgs e)
        {
            List<string> Campaign = await _apiAccessor.SendCampaign(richTextBox_CampaignName.Text, int.Parse(label_ID.Text), richTextBox_CampaignHashtag.Text, richTextBox_CampaignURL.Text);
            DataBaseAccessor.Campaigns.AddCampaigns(Campaign[0], int.Parse(Campaign[1]), Campaign[2], Campaign[3]);
        }
    }
}