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
            
        }

       



        public static void executeMyQuery(string query)
        {
            using MySqlConnection connection = new MySqlConnection(Connection.CnnVal("PromoIt"));
            MySqlCommand command;

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                command = new MySqlCommand(query, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed");
                }

                else
                {
                    MessageBox.Show("Query Not Executed");
                }

            }

            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            
             string Insert = "call AddBusiness_procedure('a', '12345','Business', ' a ')";
             executeMyQuery(Insert);
            
        }
    }



}
