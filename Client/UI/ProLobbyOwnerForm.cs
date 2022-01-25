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
    public partial class ProLobbyOwnerForm : Form
    {
        public ProLobbyOwnerForm()
        {
            InitializeComponent();
            dataGridView_Activists.DataSource = Users.AllActivistsTable();
            dataGridView_NonProfit.DataSource = Users.AlllNonProfitTable();
            dataGridView_Business.DataSource = Users.AlllBusinessTable();
            dataGridView_Campaigns.DataSource = Campaigns.AlllCampaignsTable();
            dataGridView_Tweets.DataSource = Twitter.AllTweetsTable();

        }
        






    }
}
