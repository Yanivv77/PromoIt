
namespace UI
{


    class ApiAccessor
    {
        private readonly User.UserClient _clientUser = new User.UserClient(new HttpClient());
        private readonly Shop.ShopClient _clientShop = new Shop.ShopClient(new HttpClient());
        private readonly Campaign.CampaignClient _clientCampaign = new Campaign.CampaignClient(new HttpClient());
  

        public async Task<bool> SendAsync(string username, string password)
        {
            try
            {
                await _clientUser.SendAsync(new User.User { UserName = username, Password = password });
                return true;
            }
            catch (Exception)
            {
                //todo: log
                return false;
            }
        }


         // Async method lacks 'await' operators and will run synchronously
        public async Task<List<string>> SendUser(string username, string password)

        {
            List<string> user = new List<string>();
            string name = new User.User { UserName = username, Password = password }.UserName;
            string pass = new User.User { UserName = username, Password = password }.Password;
            user.Add(name);
            user.Add(pass);
            return user;

        }

        public async Task<List<string>> SendDonation(int businessID, string campaignName, string productName,
            int productValue, int quantity)
         
        {
            List<string> DonationList = new List<string>();

            var Donation = new Shop.Donation
            {
                BusinessID = businessID,
                CampaignName = campaignName,
                ProductName = productName,
                ProductValue = productValue,
                Quantity = quantity
            };

            DonationList.Add(Donation.BusinessID.ToString());
            DonationList.Add(Donation.CampaignName);
            DonationList.Add(Donation.ProductName);
            DonationList.Add(Donation.ProductValue.ToString());
            DonationList.Add(Donation.Quantity.ToString());

       
            return DonationList;
        }

        public async Task<List<string>> SendOrder(int activistUserID, int productID )

        {
            List<String> OrderList = new List<String>();

            var Order = new Shop.Order
            {
                ActivistUserID = activistUserID,
                ProductID = productID

            };

            OrderList.Add(Order.ActivistUserID.ToString());
            OrderList.Add(Order.ProductID.ToString());


            return OrderList;
        }



        public async Task<List<string>> SendCampaign(string campaignName, int nonProfitUserID, string hashtag, string url)
       
        {
            List<String> CampaignList = new List<String>();

            var Campaign = new Campaign.Campaign
            {
                CampaignName = campaignName,
                NonProfitUserID = nonProfitUserID,
                Hashtag = hashtag,
                Url = url

            };

            CampaignList.Add(Campaign.CampaignName);
            CampaignList.Add(Campaign.NonProfitUserID.ToString());
            CampaignList.Add(Campaign.Hashtag);
            CampaignList.Add(Campaign.Url);

            return CampaignList;
        }



    }
}
