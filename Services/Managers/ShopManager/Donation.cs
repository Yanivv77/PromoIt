using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager
{
    public class Donation
    {
        public int BusinessID { get; set; }
        public string CampaignName { get; set; }
        public string ProductName { get; set; }
        public int ProductValue { get; set; }
        public int Quantity { get; set; }
    }
}
