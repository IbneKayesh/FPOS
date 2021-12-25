using System;
using System.ComponentModel.DataAnnotations;

namespace FPOS.AppModels
{
    public class TAIL_MODEL
    {
        [Display(Name = "Active")]
        public bool IS_ACTIVE { get; set; } = true;

        [Display(Name = "Create User")]
        [StringLength(10, ErrorMessage = "{0} max length is {1}")]
        public string CREATE_USER { get; set; } = Environment.UserName;

        [Display(Name = "Create Date")]
        public DateTime CREATE_DATE { get; set; } = DateTime.Now;

        [Display(Name = "Create Device")]
        [StringLength(50, ErrorMessage = "{0} max length is {1}")]
        public string CREATE_DEVICE { get; set; } = Environment.MachineName;

        [Display(Name = "Update User")]
        [StringLength(10, ErrorMessage = "{0} max length is {1}")]
        public string UPDATE_USER { get; set; } = Environment.UserName;

        [Display(Name = "Update Date")]
        public DateTime UPDATE_DATE { get; set; } = DateTime.Now;

        [Display(Name = "Update Device")]
        [StringLength(50, ErrorMessage = "{0} max length is {1}")]
        public string UPDATE_DEVICE { get; set; } = Environment.MachineName;
    }
}
