using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment.Abstract
{
    public interface ICampaign
    {
        int Id { get; set; }
        string CampaignName { get; set; }
        string CampaignDetails { get; set; }
        int CampaignRate { get; set; }
    }
}
