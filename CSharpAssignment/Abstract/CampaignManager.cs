using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment.Abstract
{
    public class CampaignManager : ICampaignManager
    {
        //Kampanya Ekleme,Silme ve Güncelle fonksiyonlarımızı simüle ediyoruz.
        public void CampaignAdd(ICampaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+" kampanyası eklenmiştir.");
        }

        public void CampaignDelete(ICampaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+"kampanyası silinmiştir.");
        }

        public void CampaignUpdate(ICampaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+ "kampanyası güncellenmiştir.");
        }
    }
}
