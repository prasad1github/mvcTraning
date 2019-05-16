using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
namespace myMvcAppTraining.Models
{
    [Table("tblEmployer")]
    public class Employer
    {

        [Key]
        public int empId { get; set; }

        [DisplayName("FirstName")]
        [Required(ErrorMessage = "Please Provide Firstname")]
        public string empFirstname { get; set; }

        [Required(ErrorMessage = "Please Provide Middlename")]
        [DisplayName("MiddleName")]
        public string empMiddlename { get; set; }

        [Required(ErrorMessage = "Please Enter Lastname")]
        [DisplayName("LastName")]
        public string empLastname { get; set; }

        [Required(ErrorMessage = "Please Select Gender")]
        [DisplayName("Gender")]
        public string empGender { get; set; }

        [Required(ErrorMessage = "Please Provide Contact no")]
        [StringLength(10,MinimumLength=10, ErrorMessage = "Please Enter 10 Digit Contact No")]
        [DataType(DataType.PhoneNumber)]
        [DisplayName("Contact Number")]
        public string empContactno { get; set; }

        [Required(ErrorMessage = "Please Provide City")]
        [DisplayName("City")]
        public string empcity { get; set; }

        [Required(ErrorMessage = "Please Provide Description")]
        [DisplayName("Description")]
        public string empDescription { get; set; }

        [Required(ErrorMessage = "Please Enter Email")]
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid Email..Please Provide Valid Email")]
        public string empUsername { get; set; }

        [Required(ErrorMessage = "Please Provide Password")]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string empPassword { get; set; }

        [Required(ErrorMessage = "Please Select Company")]
        [DisplayName("Company")]
        public int companyId { get; set; }

        [ForeignKey("companyId")]
        public virtual Company Companys { get; set; }

    }
}