using CSharpAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment.Abstract
{
    interface IGameManager
    {
        //Satış fonksiyonumuzun imzasını oluşturuyoruz.
        void Sales(IMember member,IGame game,ICampaign campaign);
    }
}
