using MySql.Data.MySqlClient;
using System.Data;
using MySQLConnection;

namespace DataBaseAccessor
{
    public class Campaigns
    {


        public static void AddCampaigns(string CampaignName, int NonProfitUserID, string Hashtag, string Url)
        {

            string AddCampaigns = $"call CreateCampaign_procedure ('{CampaignName}' ,'{NonProfitUserID}','{Hashtag}','{Url}');";
            Connection.executeMyQuery(AddCampaigns);

        }




        public static DataTable AlllCampaignsTable()
        {
            // populate the datagridview
            string selectQuery = " call DisplayAllCampaigns_procedure(); ";
            DataTable table = new DataTable();
            var adapter = Connection.Adapter(selectQuery, "PromoIt");
            adapter.Fill(table);
            return table;
        }

        public static DataTable CampaignsByNonProfitIDTable(int nonProfit_id)
        {
            // populate the datagridview
            string selectQuery = $" call DisplayCampaignsBYNonProfit_procedure('{nonProfit_id}'); ";
            DataTable table = new DataTable();
            var adapter = Connection.Adapter(selectQuery, "PromoIt");
            adapter.Fill(table);
            return table;
        }










    }
}
