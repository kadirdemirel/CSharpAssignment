using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment.Abstract
{
    public interface IGame
    {
        int Id { get; set; }
        string GameName { get; set; }
        string GameDescription { get; set; }
        int GamePrice { get; set; }
    }
}
