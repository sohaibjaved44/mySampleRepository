using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace woman_health.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("abc")
        {
            
        }
        public DbSet<StudentForm> StudentForm { get; set; }
    }
}