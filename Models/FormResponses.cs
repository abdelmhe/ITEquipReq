using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ITEquipReq.Models
{
    public class FormResponses
    {
        [Required (ErrorMessage = "Please enter your name")]
        public string Name {get; set;}

        [Required (ErrorMessage = "Please enter your email address")]
        [EmailAddress]
        public string Email {get; set;}

        [Required (ErrorMessage = "Please enter your phone number")]
        public string Phone {get; set;}
        [Required (ErrorMessage = "Please specify whether you are a professor or a student")]
        public bool? ProfOrStud {get; set;}

        public string EquipType {get; set;}

        
        
    }
}