using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork.Models
{
    public class MentorStudent
    {


        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student student { get; set; }


        public Mentor mentor { get; set; }
        public int MentorId { get; set; }

        public DateTime SignDate { get; set; }

    }
}
