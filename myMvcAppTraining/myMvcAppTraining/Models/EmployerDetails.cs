using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myMvcAppTraining.Models
{
    public class EmployerDetails
    {
        public Employer emp { get; set; }
        public IEnumerable<SelectListItem> companyList { get; set; }
    }
}