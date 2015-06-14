using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace woman_health.Models
{
    public class StudentForm
    {
        public int StudentFormID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }


        public bool Male { get; set; }

        public bool Female { get; set; }

        public Int16 MobileNo { get; set; }

        public String Skypename { get; set; }
        public Int16 Anyothercontactnumber { get; set; }
        public String Country { get; set; }
        public String City { get; set; }
   
    }
}