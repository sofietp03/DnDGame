using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDGame
{

   public  enum Characters { Fighter=1, Mage, Clerice, Bard, Rouge, Paladin, Barbarian};
    internal class Character
    {
        public int Level { get; set; }
        public Skills? Skills { get; set; }

        public Characters Characters { get; set; }

        public int Xp { get; set; }

        public string? Name { get; set; }

      

    }

    
}


