using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Hello_World.Models
{
    public class Students
    {
            public int ID { get; set; }
            public string Name{ get; set; }
        public string Department { get; set; }
        public string Course_Name { get; set; }
        public string Section { get; set; }




        [DataType(DataType.Date)]
            public DateTime Exam_Date { get; set; }
           
            
        }
    }



