using System;
using System.Collections.Generic;


namespace _2021.Models
{
    public class InfoExp
    {

        public int InfoExpID { get; set; }
        public int ExpID { get; set; }
        public int PessoalID { get; set; }

        public virtual Exp Exp { get; set; }
        public virtual Pessoal Pessoal { get; set; }
    }
}