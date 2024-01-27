using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_LESSON_1_HOME_WORK_2.Entitis
{
    public class Subject : BaseEntiti
    {

        [Column("Name", TypeName = "nvarchar(max)")]
        [Required(ErrorMessage = "Name bos ola bilmez")]

        public string Name { get; set; }
    }
}
