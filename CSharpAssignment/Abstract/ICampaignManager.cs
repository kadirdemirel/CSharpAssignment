using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment.Abstract
{
    public interface ICampaignManager
    {
        //Kampanya Ekleme,Silme ve Güncelle imzalarını oluşturuyoruz.
        void CampaignAdd(ICampaign campaign);
        void CampaignDelete(ICampaign campaign);
        void CampaignUpdate(ICampaign campaign);
    }
}
