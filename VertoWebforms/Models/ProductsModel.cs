using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VertoWebforms.Models
{
    public class ProductsModel
    {
         [Key]
        public int productId { get; set; }

        public DateTime productCreationDate { get; set; }
        
        public string Title { get; set; }
        
        public string description { get; set; }

        public int imageModelId { get; set; }

        [ForeignKey("imageModelId")]
        public virtual ImagesModel images { get; set; }

        public int catagoryModelId { get; set; }

        [ForeignKey("catagoryModelId")]
        public virtual catagoriesModel catagory { get; set; }
    
    }
}
