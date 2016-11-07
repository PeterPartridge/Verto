using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VertoWebforms.Models
{
    public class GalleryModel
    {
        [Key]
        public int galleryId { get; set; }

        public string title { get; set; }

        public string description { get; set; }

        public DateTime galleryDate { get; set; }

        public int imageModelId { get; set; }

        [ForeignKey("imageModelId")]
        public virtual ImagesModel images { get; set; }
    }
}
