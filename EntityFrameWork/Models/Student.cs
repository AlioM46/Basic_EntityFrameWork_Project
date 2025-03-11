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
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Column("Name", TypeName = "nvarchar(30)")]
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }


        [Column(TypeName = "nvarchar(15)")]
        public string? Phone { get; set; }
        public int Level { get; set; }


        [NotMapped]
        public string Age
        {
            get
            {
                return Utilities.CalculateAge(BirthDate);
            }

        }

        [NotMapped]

        public enLevels LevelName
        {
            get { return (enLevels)Level; }

            set
            {
                Level = (int)value;
            }
        }


        [ForeignKey("ClubId")]
        public int ClubId { get; set; }
        public Club Club { get; set; }

        public ICollection<MentorStudent> MentorStudents { get; set; }



    }
}
