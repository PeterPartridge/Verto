using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VertoWebforms.Models
{
    public class catagoriesModel
    {
        [Key]
        public int CatagoryId { get; set; }

        public string Catagory { get; set; }

        public int imageModelId { get; set; }

        [ForeignKey("imageModelId")]
        public virtual ImagesModel images { get; set; }

  
    }
}