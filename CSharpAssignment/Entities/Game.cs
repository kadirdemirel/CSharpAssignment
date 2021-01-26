using CSharpAssignment.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment.Entities
{
    public class Game:IGame
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string GameDescription { get; set; }
        public int GamePrice { get; set; }

    }
}
