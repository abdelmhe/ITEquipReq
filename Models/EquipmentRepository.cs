using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITEquipReq.Models
{
    public static class EquipmentRepository
    {
        private static List<Equipment> _equipment; 

        static EquipmentRepository()
        {
            _equipment = new List<Equipment>();
            PopulateEquipment();
        }


        


        private static void PopulateEquipment()
        {

            _equipment = new List<Equipment> 
            {
                new Equipment 
                        {
                            Id = 73,
                            Type="Laptop",
                            Description="Macbook pro 16-inch 2019",
                            Availability= true
                        },
                new Equipment 
                        {
                            Id = 75,
                            Type="Phone",
                            Description="Iphone 13 pro",
                            Availability= true
                           
                        }, 
                new Equipment 
                        {
                            Id = 77,
                            Type="Tablet",
                            Description="Ipad 2017",
                            Availability= false
                           
                        }, 
                                  
            };

            
        }

        public static IEnumerable<Equipment> GetEquipment()
        {
            return _equipment;
        }


        
        
    }
}