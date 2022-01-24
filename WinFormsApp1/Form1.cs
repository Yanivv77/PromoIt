using MySql.Data.MySqlClient;
using System.Data;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadCarsToGrid();
        }

        public void LoadCarsToGrid()
        {


            // populate the datagridview
            string selectQuery = " call DisplayAllTweets_procedure(); ";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, MySQLConnection.Connection.CnnVal("PromoIt"));
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    }



}
