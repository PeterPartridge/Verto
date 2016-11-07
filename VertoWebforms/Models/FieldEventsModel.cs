using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VertoWebforms.Models
{
    public class FieldEventsModel
    {
         [Key]
        public int FeildeventId { get; set; }

        public DateTime EventCreationDate { get; set; }
        
        public string Title { get; set; }
        
        public string description { get; set; }

        public int imageModelId { get; set; }

        [ForeignKey("imageModelId")]
        public virtual ImagesModel images { get; set; }
    }
}
