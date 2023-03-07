using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Owner : BaseEntitie
    {
        public Owner()
        {
            Drugstores = new List<Drugstore>();
        }

        public string Name { get; set; }
        public string Surname { get; set; }
       

        public readonly List<Drugstore> Drugstores;

        
    }
}
