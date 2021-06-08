using GameStoreProject.Abstract;
using GameStoreProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreProject.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası eklendi." + " Bu kampanya sayesinde %" + campaign.CampaignDiscount + " tutarında indirim kullanabileceksiniz.");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------");
            
        }       

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası güncellendi.");
            Console.WriteLine("Güncel kampanya indirimi " + campaign.CampaignDiscount);
        }
    }
}
