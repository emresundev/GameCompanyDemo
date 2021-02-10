using System;

namespace GameCompanyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new GamerValidatitonManager());
            Gamer gamer = new Gamer();
            gamer.Id = 1;
            gamer.FirstName = "Emre";
            gamer.LastName = "Sunar";
            gamer.BirthYear = 1990;
            gamer.IdentityNumber = 12345678910;
            
            gamerManager.Add(gamer);

            Campaign campaign = new Campaign();
            campaign.CampaignId = 1;
            campaign.DiscountRate = 0.2;
            campaign.CampaignName = "New gamer discount";

            OrderManager orderManager = new OrderManager(new CampaignManager());

            orderManager.Sale(gamer, campaign);
        }
    }
}
