using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITEquipReq.Models
{
    public class Equipment
    {
        
        public double Id { get;  set; }

        public string Description { get; set; } = string.Empty;

        public bool Availability { get; set; }





        private string _type;
        public string  Type
        {
            get { return _type; }
            set { _type = value; }
        }
        
       
        
    }
}