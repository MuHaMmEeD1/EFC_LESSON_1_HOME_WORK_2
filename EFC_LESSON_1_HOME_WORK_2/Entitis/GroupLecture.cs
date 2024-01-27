using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_LESSON_1_HOME_WORK_2.Entitis
{
    public class GroupLecture : BaseEntiti
    {
        [ForeignKey(nameof(Lecture))]
        public int LectureId { get; set; }
        public Lecture Lecture { get; set; }


        [ForeignKey(nameof(Group))]
        public int GroupId { get; set; }
        public Group Group { get; set; }

    }
}
