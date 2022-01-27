using MySQLConnection;
using System.Data;

namespace DataBaseAccessor
{
    public class Users
    {


        public static void AddActivist(string username, string passwrod, string usertype
            ,string email, string adress, string phone, string twitterName)
        {

            string AddActivist = $"call AddActivist_procedure ('{username}' ,'{passwrod}' , '{usertype}' ,'{email}','{adress}','{phone}','{twitterName}' );";
            Connection.executeMyQuery(AddActivist);

        }

        public static void AddNonProfit(string username,string passwrod, string usertype
            ,string name, string email, string url)
        {

            string AddNonProfit = $"call AddNonProfit_procedure ('{username}' ,'{passwrod}' , '{usertype}' ,'{name}','{email}','{url}' );";
            Connection.executeMyQuery(AddNonProfit);

        }

        public static void AddBusiness(string username, string passwrod, string usertype
            ,string name)
        {

            string AddBusiness = $"call AddBusiness_procedure ('{username}' ,'{passwrod}' , '{usertype}' ,'{name}');";
            Connection.executeMyQuery(AddBusiness);

        }

        public static DataTable GetTypeInDataTable(string username )

        {
            // populate the datagridview
            string selectQuery = $" DisplyUserTypeByUsername_procedure('{username}'); ";
            DataTable table = new DataTable();
            var adapter = Connection.Adapter(selectQuery, "PromoIt");
            adapter.Fill(table);
            return table;

        }




        public static DataTable AllActivistsTable()
        {

            // populate the datagridview
            string selectQuery = " call DisplayAllActivists_procedure(); ";
            DataTable table = new DataTable();
            var adapter = Connection.Adapter(selectQuery, "PromoIt");
            adapter.Fill(table);
            return table;
        }


        public static DataTable AlllBusinessTable()
        {

            // populate the datagridview
            string selectQuery = " call DisplayAllBusiness_procedure(); ";
            DataTable table = new DataTable();
            var adapter = Connection.Adapter(selectQuery, "PromoIt");
            adapter.Fill(table);
            return table;
        }

        public static DataTable AlllNonProfitTable()
        {

            // populate the datagridview
            string selectQuery = " call DisplayAllNonProfit_procedure(); ";
            DataTable table = new DataTable();
            var adapter = Connection.Adapter(selectQuery, "PromoIt");
            adapter.Fill(table);
            return table;
        }



    }
}