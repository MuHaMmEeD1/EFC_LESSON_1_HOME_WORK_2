using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_LESSON_1_HOME_WORK_2.Entitis
{
    public class Curator : BaseEntiti
    {
        [Column("Name", TypeName = "nvarchar(Max)")]
        [Required(ErrorMessage = "Name bos ola bilmez")]
        public string Name { get; set; }

        [Column("Surname", TypeName = "nvarchar(Max)")]
        [Required(ErrorMessage = "Surname bos ola bilmez")]
        public string Surname { get; set; }

    }
}
