using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_LESSON_1_HOME_WORK_2.Entitis
{
    public class Group : BaseEntiti
    {

        //[Index(IsUnique = true)] islemir
        [Column("Name", TypeName = "nvarchar(10)")]
        [Required(ErrorMessage = "Name bos ola bilmez")]

        public string Name { get; set; }


        [Range(1, 5, ErrorMessage = "1 ile 5 arasinda ola biler")]
        [Required]
        public int Year { get; set; }

        [ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }

    }
}
