using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace myMvcAppTraining.Models
{
    [Table("tblCompany")]
    public class Company
    {
        [Key]
        public int companyId { get; set; }
        
        [DisplayName("Company")]
        public string name { get; set; }

        [DisplayName("Website")]
        public string website { get; set; }

        [DisplayName("Description")]
        public string description { get; set; }

        [DisplayName("Email")]
        public string email { get; set; }

        [DisplayName("Contactno")]
        public string contactno { get; set; }
        
    }
}