using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2021.Models
{
    public class Exp
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ExpID { get; set; }
        public string Funçao { get; set; }
       

        public virtual ICollection<InfoExp> Enrollments { get; set; }
    }
}