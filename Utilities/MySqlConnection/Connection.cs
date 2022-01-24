
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



        public void openConnection()
        {
            using MySqlConnection connection = new MySqlConnection(CnnVal("PromoIt"));

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }


        public void closeConnection()
        {
            using MySqlConnection connection = new MySqlConnection(CnnVal("PromoIt"));

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }


        public void executeMyQuery(string query)
        {


            using MySqlConnection connection = new MySqlConnection(CnnVal("PromoIt"));


            try
            {
                openConnection();
                var command = new MySqlCommand(query, connection);

                //if (command.executenonquery() == 1)
                //{
                //    messagebox = "query executed";
                //}

                //else
                //{
                //    messagebox = "query not executed";
                //}

            }

            finally
            {
                closeConnection();
            }


        }

    }
}