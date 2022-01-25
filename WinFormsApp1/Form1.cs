using MySql.Data.MySqlClient;
using System.Data;
using MySQLConnection;

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
            string selectQuery = " call DisplayAllActivists_procedure();; ";
            DataTable table = new DataTable();
            var adapter = Connection.Adapter(selectQuery, "PromoIt");
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    }



}
