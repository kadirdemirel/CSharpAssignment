using CSharpAssignment.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment.Entities
{
    class Campaign:ICampaign
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public string CampaignDetails { get; set; }
        public int CampaignRate { get; set; }
    }
}
