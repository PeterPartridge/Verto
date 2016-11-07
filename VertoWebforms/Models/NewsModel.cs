using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VertoWebforms.Models
{
    public class NewsModel
    {
        [Key]
        public int storyId { get; set; }

        public DateTime ArticleCreationDate { get; set; }

        public string Title { get; set; }
        
        public string story { get; set; }

        public int imageModelId { get; set; }

        [ForeignKey("imageModelId")]
        public virtual ImagesModel images { get; set; }
    }
}
