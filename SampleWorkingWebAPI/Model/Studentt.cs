using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using SampleWorkingWebAPI.Model;

namespace SampleWorkingWebAPI.Model
{
    [Table("Studentt")]
    public class Studentt
    {
        [Key]
        public int RollNo { get; set; }
        public string Name { get; set; }
        public decimal Percentage { get; set; }
    }
}
