//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.student_tute = new HashSet<student_tute>();
            this.subjects = new HashSet<subject>();
            this.marksInfoes = new HashSet<marksInfo>();
            this.student_attendence = new HashSet<student_attendence>();
        }
    
        public int Id { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Full_Name { get; set; }

        [Required(ErrorMessage = "Required")]
        public string School { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Division { get; set; }

        [Required(ErrorMessage = "Required")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                           @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                           @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                           ErrorMessage = "Email is not valid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Required")]
        [Range(0, 9999999999, ErrorMessage = "Enter a valid phone number")]
        public string Contact_No { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Parent_Name { get; set; }

        [Required(ErrorMessage = "Required")]
        [Range(0, 9999999999, ErrorMessage = "Enter a valid phone number")]
        public string Parent_Mobile { get; set; }
        
        [Required(ErrorMessage = "Required")]
        [Range(0, 9999999999, ErrorMessage = "Enter a valid phone number")]
        public string Parent_Work { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<student_tute> student_tute { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<subject> subjects { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<marksInfo> marksInfoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<student_attendence> student_attendence { get; set; }
    }
}
