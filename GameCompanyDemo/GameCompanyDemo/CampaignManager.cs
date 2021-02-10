using System;
using System.Collections.Generic;
using System.Text;

namespace GameCompanyDemo
{
    class CampaignManager : ICampaignService
    {
        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine("New campaign has been defined to the gamer. Discount rate is: " + campaign.DiscountRate);
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine("The campaign has been deleted.");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine("The campaign has been defined to gamer is updated. New discount rate is: " + campaign.DiscountRate);
        }
    }
}
