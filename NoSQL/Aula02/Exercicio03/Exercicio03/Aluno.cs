using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace Exercicio03
{
    [Serializable]
    public class Aluno
    {
        public Aluno() { }

        public Aluno(string nome, DateTime dataNascimento)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
        }

        [BsonElement("_id")]
        public ObjectId Id { get; set; }

        [BsonElement("nome_aluno")]
        public string Nome { get; set; }

        [BsonElement("data_nascimento")]
        public DateTime DataNascimento { get; set; }

        [BsonElement("disciplinas")]
        public List<Disciplina> Disciplinas { get; set; }
    }
}
