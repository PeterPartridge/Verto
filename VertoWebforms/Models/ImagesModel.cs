using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VertoWebforms.Models
{
    public class ImagesModel
    {
        [Key]
        public int imageId { get; set; }

        public string imageLocation { get; set; }

        public DateTime imageUploadDate { get; set; }
    }
}