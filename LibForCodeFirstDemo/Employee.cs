using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibForCodeFirstDemo
{
    [Table("Emp")]
    public class Employee
    {
        [Key]
        [Display(Name ="Enter Employee ID:")]
        public int Empid { get; set; }

        [Display(Name ="Enter Employee Name:")]
        [Required(AllowEmptyStrings=false,ErrorMessage ="Name is compulsory and cannot be empty")]
        public string EmpName { get; set; }



        [DataType(DataType.EmailAddress,ErrorMessage ="Enter valid email id/address")]
        [Display(Name ="Enter Email Address")]

        public string EmailAdd { get; set; }

        [Range(18,60,ErrorMessage ="Age not valid")]
        public int Age { get; set; }

    }
}
