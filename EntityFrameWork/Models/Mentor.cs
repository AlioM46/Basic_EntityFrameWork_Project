using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntityFrameWork.CollectionOfEnums;

namespace EntityFrameWork.Models
{
    public class Mentor
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string Name { get; set; }


        [Column(TypeName = "nvarchar(100)")]

        public string? Description { get; set; }

        public int CategoryId { get; set; }

        public ICollection<MentorStudent> MentorStudents { get; set; }

        [NotMapped]
        public CollectionOfEnums.enCategories CategoryName
        {
            get
            { return (enCategories)CategoryId; }
            set
            { CategoryId = (int)CategoryName; }
        }
    }
}
