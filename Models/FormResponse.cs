using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ITEquipReq.Models
{
    public class FormResponse
    {
        [Required (ErrorMessage = "Please enter your name")]
        public string Name {get; set;}

        [Required (ErrorMessage = "Please enter your email address")]
        [EmailAddress]
        public string Email {get; set;}

        [Required (ErrorMessage = "Please enter your phone number")]

        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        
        public string Phone {get; set;}
        
        [Required (ErrorMessage = "Please specify whether you are a professor or a student")]
        public bool? ProfOrStud {get; set;}

        public string EquipType {get; set;}

        [Required (ErrorMessage = "Please enter your request details")]
        public string RequestDetails {get; set;}

        [Required (ErrorMessage = "Please enter the duration needed")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public int Duration {get; set;}
        

        
        
    }
}