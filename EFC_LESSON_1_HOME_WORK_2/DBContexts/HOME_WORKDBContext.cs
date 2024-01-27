using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFC_LESSON_1_HOME_WORK_2.Entitis;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace EFC_LESSON_1_HOME_WORK_2.DBContexts
{
    public class HOME_WORKDBContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string strConnection = "Data Source=DESKTOP-RV3QOTA\\SQLEXPRESS;Initial Catalog=HomeWork2;User Id=login;Password=123;";

            optionsBuilder.UseSqlServer(strConnection);
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Curator> Curators { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Facultie> Faculties { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupCurator> GroupCurators { get; set; }
        public DbSet<GroupLecture> GroupLectures { get; set;}
        public DbSet<GroupStudent> GroupStudents { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }



    }
}
