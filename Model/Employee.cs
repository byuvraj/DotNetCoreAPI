using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace July7API.Model
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
    }
}
