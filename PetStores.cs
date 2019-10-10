using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dog_Pet.Data
{
    public class PetStores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PSID { get; set; }
        [Display(Name = "Pet Store Name")]
        public string PSN { get; set; }
        [Display(Name = "Pet Store Food")]

        public string PSF { get; set; }
       

    }
}
