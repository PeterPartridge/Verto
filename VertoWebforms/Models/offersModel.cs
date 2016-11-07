using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VertoWebforms.Models
{
    public class offersModel
    {
        [Key]
        public int offerId { get; set; }

        public string offerTitle { get; set; }

        public string Offer { get; set; }

        public DateTime offerDate { get; set; }

        public int imageModelId { get; set; }

        [ForeignKey("imageModelId")]
        public virtual ImagesModel images { get; set; }
    }
}
