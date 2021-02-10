using System;
using System.Collections.Generic;
using System.Text;

namespace GameCompanyDemo
{
    interface ICampaignService
    {
        void AddCampaign(Campaign campaign);

        void UpdateCampaign(Campaign campaign);

        void DeleteCampaign(Campaign campaign);
    }
}
