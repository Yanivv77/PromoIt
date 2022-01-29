using MySQLConnection;
using System.Data;


namespace DataBaseAccessor
{
    public class Shop
    {

       

        public static void AddProductDonation(string BusinessID, string CampaignName,
            string ProductName, int ProductValue, int Quantity)

        {

            string AddBusiness = $"call ProductDonation_procedure ( '{BusinessID}' , '{CampaignName}' ,'{ProductName}','{ProductValue}','{Quantity}');";
            Connection.executeMyQuery(AddBusiness);

        }

        public static void AddOrder(string username, string passwrod, string usertype, string name)

        {

            string AddBusiness = $"call AddBusiness_procedure ('{username}' ,'{passwrod}' , '{usertype}' ,'{name}');";
            Connection.executeMyQuery(AddBusiness);

        }



        public static DataTable AllDonationsTable()
        {

            // populate the datagridview
            string selectQuery = " call DisplayAllDonations_procedure(); ";
            DataTable table = new DataTable();
            var adapter = Connection.Adapter(selectQuery, "PromoIt");
            adapter.Fill(table);
            return table;
        }

        public static DataTable DonationsBYBusiness(int BusinessID)
        {

            // populate the datagridview
            string selectQuery = $" call DisplayDonationsBYBusiness_procedure('{BusinessID}'); ";
            DataTable table = new DataTable();
            var adapter = Connection.Adapter(selectQuery, "PromoIt");
            adapter.Fill(table);
            return table;
        }

       
        public static DataTable OrdersByBusiness(int BusinessID)
        {

            // populate the datagridview
            string selectQuery = $" call DisplayOrdersBYBusiness_procedure('{BusinessID}'); ";
            DataTable table = new DataTable();
            var adapter = Connection.Adapter(selectQuery, "PromoIt");
            adapter.Fill(table);
            return table;
        }
        public static DataTable OrdersByActivist(int ActivistID)
        {

            // populate the datagridview
            string selectQuery = $" call DisplayOrdersBYActivist_procedure('{ActivistID}'); ";
            DataTable table = new DataTable();
            var adapter = Connection.Adapter(selectQuery, "PromoIt");
            adapter.Fill(table);
            return table;
        }



    }
}
