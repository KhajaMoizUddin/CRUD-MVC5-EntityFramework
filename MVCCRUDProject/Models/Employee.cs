using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCRUDProject.Models
{
    public class Employee
    {

        [Key]
        public int EmployeeId { get; set; }
        [Display(Name = "Employee Name")]
        public string EmployeeName { get; set; }
        [Display(Name = "Designation")]
        public string EmployeeDesignation { get; set; }
        

        public Department Department { get; set; }
        [Display(Name = "Address")]
        public string EmployeeAddress { get; set; }
        [Display(Name = "Passport")]
        public string EmployeePassport { get; set; }
        [Display(Name = "Phone")]
        public int EmployeePhone { get; set; }
        [Display(Name = "Gender")]
        public string EmployeeGender { get; set; }
        [Display(Name = "City")]
        public string City { get; set; }
        [Display(Name="Project")]
        public string Project { get; set; }
        [Display(Name="Company Name")]
        public string CompanyName { get; set; }
        [Display(Name = "Pin Code")]
        public int PinCode { get; set; }
        [Display(Name = "Dept Name")]
        public int DepartmentId { get; set; }
    }
}