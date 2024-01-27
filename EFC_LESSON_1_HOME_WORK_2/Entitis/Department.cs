using Microsoft.EntityFrameworkCore;
using Microsoft;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EFC_LESSON_1_HOME_WORK_2.Entitis
{
    public class Department : BaseEntiti
    {


        [Range(1, 5, ErrorMessage = "1 ile 5 arasinda ola biler")]
        [Required]
        public int BNumber { get; set; }


        [Column("Financing", TypeName = "money")]
        [Range(0, int.MaxValue, ErrorMessage = "Financing 0 balaca ola bi" +
            "lmez")]
        public double Financing { get; set; } = 0;

        //[Index(IsUnique = true)] islemir
        [Column("Name", TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "Name bos ola bilmez")]
        
        public string Name { get; set; }

        [ForeignKey(nameof(Facultie))]
        public int FacultyId { get; set; }
        public Facultie Facultie { get; set; }

    }
}
