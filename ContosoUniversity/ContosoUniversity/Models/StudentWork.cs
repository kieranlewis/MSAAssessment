using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class StudentWork
    {
        public int StudentWorkID { get; set; }
        public int StudentID { get; set; }
        public string LinkName { get; set; }
    }
}