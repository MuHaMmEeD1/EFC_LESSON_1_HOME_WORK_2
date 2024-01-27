using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_LESSON_1_HOME_WORK_2.Entitis
{
    public class Facultie : BaseEntiti
    {

        //[Index(IsUnique = true)] islemir
        [Column("Name", TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "Name bos ola bilmez")]
        public string Name { get; set; }


    }
}
