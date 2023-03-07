using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Drugstore : BaseEntitie
    {
        
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public List<Druggist> Druggists { get; set; }
        public Drugstore()
        {
            Druggists = new List<Druggist>();
            Drugs = new List<Drug>();
        }
        public List<Drug> Drugs { get; set; }
        public Owner Owner { get; set; }


    }
    
}
