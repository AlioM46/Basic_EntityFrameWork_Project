using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork.Models
{
    public class Club
    {
        [Key]
       public int Id { get; set; }
        public string ClubName { get; set; }
        public int CategoryId { get; set; }


        [NotMapped]
        public CollectionOfEnums.enCategories CategoryName
        {
            get { return (CollectionOfEnums.enCategories)CategoryId; }
            set { CategoryId = (int)CategoryName; }
        }



        public ICollection<Student> Students { get; set; }  
    
    
    
    
    }
}
