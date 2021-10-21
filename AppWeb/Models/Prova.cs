﻿using System.ComponentModel.DataAnnotations;

namespace AppWeb.Models
{
    public class Prova
    {
        [Key]
        public int ProvaId { get; set; }
        public string Materia { get; set; }
        public double Nota { get; set; }


        public  AlunoModel Aluno { get; set; }
        public int AlunoId { get; set; }

    }
}