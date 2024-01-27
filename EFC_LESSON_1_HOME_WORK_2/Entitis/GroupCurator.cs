using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_LESSON_1_HOME_WORK_2.Entitis
{
    public class GroupCurator : BaseEntiti
    {
        [ForeignKey(nameof(Curator))]
        public int CuratorId { get; set; }
        public Curator Curator { get; set; }


        [ForeignKey(nameof(Group))]
        public int GroupId { get; set; }
        public Group Group { get; set; }

    }
}
