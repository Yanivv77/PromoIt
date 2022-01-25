using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySQLConnection;
using System.Data;

namespace DataBaseAccessor
{
    public class Twitter
    {

        public static void AddTweet(string activist_id, string text)
        {

            string AddTweet = $"call AddTweet_procedure ('{activist_id}' ,'{text}' );";
            Connection.executeMyQuery(AddTweet);

        }


            public static DataTable AllTweetsTable()
        {
            // populate the datagridview
            string selectQuery = " call DisplayAllTweets_procedure(); ";
            DataTable table = new DataTable();
            var adapter = Connection.Adapter(selectQuery, "PromoIt");
            adapter.Fill(table);
            return table;
        }

    }
}
