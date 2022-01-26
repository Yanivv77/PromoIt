
using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows;



namespace MySQLConnection
{
    public class Connection
    {


        public static string CnnVal(string name)
        {

            return "Server=127.0.0.1;Port=3307;Database=PromoIt;Uid=root;Pwd=rootp;";
            //return ConfigurationManager.ConnectionStrings[name].ConnectionString;

        }
        public static MySqlDataAdapter Adapter(string selectQuery, string CnnValName)
        {
            return new MySqlDataAdapter(selectQuery, CnnVal(CnnValName));
        }


        public static void openConnection()
        {
            using MySqlConnection connection = new MySqlConnection(CnnVal("PromoIt"));

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }


        public static void closeConnection()
        {
            using MySqlConnection connection = new MySqlConnection(CnnVal("PromoIt"));

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
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
                    //MessageBox.Show("Query Executed");
                }

                else
                {
                    //MessageBox.Show("Query Not Executed");
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





    }
}