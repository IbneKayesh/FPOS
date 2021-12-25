using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FPOS.AppModels
{
    public class PRODUCT_BRANDS : TAIL_MODEL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        public int ID { get; set; }

        [Display(Name ="Brand Name")]
        [StringLength(50, ErrorMessage = "{0} length is between {1} and {2}", MinimumLength = 3)]
        public string BRAND_NAME { get; set; }

        [Display(Name = "Brand Origin")]
        [StringLength(50, ErrorMessage = "{0} max length is {1}")]
        public string BRAND_ORIGIN { get; set; }
    }
}
