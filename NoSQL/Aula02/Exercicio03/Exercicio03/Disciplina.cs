using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class Disciplina
    {
        public Disciplina() { }

        public Disciplina(string nome, bool cursada, double nota)
        {
            this.Nome = nome;
            this.Cursada =  cursada;
            this.Nota = nota;
        }

        public string Nome { get; set; }

        public bool Cursada { get; set; }

        public double Nota { get; set; }
    }
}
