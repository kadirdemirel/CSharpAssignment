using CSharpAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment.Abstract
{
    public  class GameManager : IGameManager
    {
        //Satış fonksiyonumuzu simüle ediyoruz.
        public  void Sales(IMember member, IGame game,ICampaign campaign)
        {
            Console.WriteLine(game.GameName + " " + " oyunu " + game.GamePrice + " TL yerine" +" sadece " + (game.GamePrice-(game.GamePrice*campaign.CampaignRate)/100) + "TL tutarına satılmıştır." +
            " Oyunu satan oyuncunun adı : " + member.FirstName +" " + member.LastName);
            Console.WriteLine(campaign.CampaignDetails+" %" + campaign.CampaignRate+" "+  campaign.CampaignName + " indirimi uygulanmıştır.");
        }

        
    }
}
