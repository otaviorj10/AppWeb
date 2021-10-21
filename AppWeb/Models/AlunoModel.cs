using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppWeb.Models
{
    public class AlunoModel
    {
        [Key]
        public int AlunoId {  get; set; }
        public string NomeAluno { get; set; }

        public  Prova Prova { get; set; }
    }
}
