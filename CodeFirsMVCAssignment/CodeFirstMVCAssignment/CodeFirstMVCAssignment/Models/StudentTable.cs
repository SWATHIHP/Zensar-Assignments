using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstMVCAssignment.Models
{
    public class StudentTable
    {
        [Key]
        public int StudentId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Branch { get; set; }
        public int Percentage { get; set; }
    }
    public class StudentEntities : DbContext
    {
        public DbSet<StudentTable> StudentTable { get; set; }
    }
}