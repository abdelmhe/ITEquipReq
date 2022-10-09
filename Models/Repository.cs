using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITEquipReq.Models
{
    public static class Repository
    {
        private static List<FormResponse> responses = new List<FormResponse>();
        public static IEnumerable<FormResponse> Responses => responses;

        public static int id =0;

        public static void AddResponse (FormResponse response)
        {
            responses.Add(response);
            id= id+1;

        }
        
    }
}