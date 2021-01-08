using System;
using System.Collections.Generic;


namespace _2021.Models
{
    public class Pessoal
    {
        public int PessoalID { get; set; }
        public string Ulnome { get; set; }
        public string Prnome { get; set; }
        public DateTime ExpDate { get; set; }

        public virtual ICollection<InfoExp> Enrollments { get; set; }
    }
}