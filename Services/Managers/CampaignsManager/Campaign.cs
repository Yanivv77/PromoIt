using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignsManager
{
    public class Campaign
    {
        public string CampaignName { get; set; }
        public int NonProfitUserID { get; set; }
        public string Hashtag { get; set; }
        public string Url { get; set; }
    }
}
