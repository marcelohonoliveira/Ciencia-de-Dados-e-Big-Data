using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Exercicio03
{
    /*
    *** PREPARAÇÃO DO AMBIENTE E DOS DADOS ***

        1) Instalar pacote MongoDB à Solução:
            Referência:
                https://www.nuget.org/packages/MongoDB.Driver/2.3.0
            Comando PMC:
                PM> Install-Package MongoDB.Driver -Version 2.3.0

        2) Iniciar o serviço do MongoDB:
            CMD como Administrador:
                cd "C:\Program Files\MongoDB\Server\3.2\bin"
                mongod --dbpath="C:/Program Files/MongoDB/Data1"
    */
    class Program
    {
        public static string nome;
        public static DateTime dataNascimento;
        public static List<Disciplina> disciplinas = new List<Disciplina>();

        static void Main(string[] args)
        {
            string conexaoMongo = "mongodb://localhost/";
            var client = new MongoClient(conexaoMongo);
            var db = client.GetDatabase("Exercicio03");
            var col = db.GetCollection<Aluno>("Alunos");

            col.DeleteMany(FilterDefinition<Aluno>.Empty);

            nome = "Aluno01";
            dataNascimento = new DateTime(1981, 7, 23);

            col.InsertOne(new Aluno(nome, dataNascimento));

            disciplinas.Add(new Disciplina("NSQ", true, 85.5));
            disciplinas.Add(new Disciplina("AQD", false, 0.0));

            var builderF = Builders<Aluno>.Filter;
            var filter = builderF.Eq(aluno => aluno.Nome, "Aluno01");

            var builderU = Builders<Aluno>.Update;
            var update = builderU.Set(aluno => aluno.Disciplinas, disciplinas);

            col.UpdateMany(filter, update);


            filter = builderF.Eq(aluno => aluno.Nome, "Aluno01") & builderF.Eq(aluno => aluno.Disciplinas[1].Nome, "AQD");
            update = builderU.Set(aluno => aluno.Disciplinas[1].Nota, 75.0);

            col.UpdateMany(filter, update);


            var resultado1 = col.Find<Aluno>(FilterDefinition<Aluno>.Empty).ToList<Aluno>();

            foreach (var doc in resultado1)
            {
                Console.WriteLine(doc.ToJson());
            }

            Console.ReadKey();
        }
    }
}
