﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDoLivro.Domains
{
    public class Autor
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public List<Livro> Livros { get; set; }
    }
}
