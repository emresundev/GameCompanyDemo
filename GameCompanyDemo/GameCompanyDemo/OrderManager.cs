using System;
using System.Collections.Generic;
using System.Text;

namespace GameCompanyDemo
{
    class OrderManager : IOrderService
    {
        ICampaignService _campaignService;

        public OrderManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

       

        public void Sale(Gamer gamer, Campaign campaign)
        {
            Console.WriteLine("The game has been sold to the gamer: " + gamer.FirstName+ gamer.LastName + " with " + campaign.CampaignName + "with"
                + campaign.DiscountRate + " discount rate.");
        }
    }
}
