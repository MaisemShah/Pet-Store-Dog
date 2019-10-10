using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dog_Pet.Data
{
    public class Dogs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DID { get; set; }
        [Display(Name = "Dog Name")]

        public string DN { get; set; }
        [Display(Name = "Dog Breed")]

        public string DB { get; set; }

        public int PSID { get; set; }
        [ForeignKey("PSID")]
        public PetStores PetSID { get; set; }

    }
}
