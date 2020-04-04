//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Studentmanagmentsystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class StudentTB
    {
        public int sid { get; set; }

        [DisplayName("Full Name")]
        [Required(ErrorMessage = "Please enter name")]
        public string fullname { get; set; }

        [DisplayName("School")]
        [Required(ErrorMessage = "Please enter school")]
        public string school { get; set; }

        [DisplayName("Username")]
        [Required(ErrorMessage = "Please enter username")]
        public string username { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Please enter email")]
        public string email { get; set; }

        [DataType(DataType.Password)]
        [DisplayName("Password")]
        [Required(ErrorMessage = "Please enter password")]
        public string password { get; set; }

        [DisplayName("Address")]
        [Required(ErrorMessage = "Please enter address")]
        public string address { get; set; }

        [DisplayName("Grade")]
        [Required(ErrorMessage = "Please enter grade")]
        public string grade { get; set; }

        [DisplayName("Gender")]
        [Required(ErrorMessage = "Please enter gender")]
        public string gender { get; set; }

        [DisplayName("Subject")]
        [Required(ErrorMessage = "Please enter subject")]
        public string subject { get; set; }

        [DisplayName("Telephone Number")]
        [Required(ErrorMessage = "Please enter telephone number")]
        public string tpnum { get; set; }

        [DisplayName("ParentName")]
        [Required(ErrorMessage = "Please enter parent name")]
        public string parentname { get; set; }

        [DisplayName("Parent Telephone Number")]
        [Required(ErrorMessage = "Please enter parent telephone number")]
        public string parenttpnum { get; set; }

        [DisplayName("Choice Youer Image")]
        [Required(ErrorMessage = "Please uplod image")]
        public string imagepath { get; set; }
    }
}
