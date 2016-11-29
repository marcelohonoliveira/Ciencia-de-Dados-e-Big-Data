using System;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace Exercicio02
{
    /*
            *** PREPARAÇÃO DO AMBIENTE E DOS DADOS ***

        1) Instalar pacote MongoDB à Solução:
            Referência:
                https://www.nuget.org/packages/MongoDB.Driver/2.3.0
            Comando:
                PM> Install-Package MongoDB.Driver -Version 2.3.0

        2) Iniciar o serviço do MongoDB:
            CMD como Administrador:
                cd C:\Program Files\MongoDB\Server\3.2\bin
                mongod --dbpath="C:/Program Files/MongoDB/Data" --storageEngine=mmapv1

        3) Remover documentos cujo "label" não foi definido.
           Exemplo: {"_id":"ouvidimho","text":"ouvidimho","total":1,"type":5,"label":{"$undefined":true}}
                db.Vocabulary.find({ label: {$type: 6}}).count()
                    12516
                db.Vocabulary.remove({ label: {$type: 6}})
                    WriteResult({ "nRemoved" : 12516 })

        Remover documentos cujo "_id" é do tipo "ObjectId"
                db.Vocabulary.find({ _id: {$type: 7}}).count()
                    44
                db.Vocabulary.remove({ _id: {$type: 7}})
                    WriteResult({ "nRemoved" : 44 })
    */

    class Program
    {
        public static int twitter, hashtag, url;

        static void Main(string[] args)
        {
            try
            {
                string conexaoMongo = "mongodb://localhost/";
                var client = new MongoClient(conexaoMongo);
                var db = client.GetDatabase("Exercicio02");
                var col = db.GetCollection<Vocabulary>("Vocabulary", null);

                var resultado1 = (from vocabulary in col.AsQueryable<Vocabulary>()
                                  orderby vocabulary.total descending
                                  select vocabulary).Take<Vocabulary>(10);

                foreach (var doc in resultado1)
                {
                    Console.WriteLine(doc.ToJson());
                }

                var resultado2 = from vocabulary in col.AsQueryable<Vocabulary>()
                                 orderby vocabulary._id ascending
                                 select vocabulary;



                foreach (var doc in resultado2)
                {
                    if (doc._id.Length > 1 && doc._id.Substring(0, 1).Equals("@"))
                    {
                        twitter++;
                        Console.WriteLine("{0}. Usuário Twitter: {1}", twitter, doc._id);
                    }
                    if (doc._id.Length > 1 && doc._id.Substring(0, 1).Equals("#"))
                    {
                        hashtag++;
                        Console.WriteLine("{0}. Hashtag: {1}", hashtag, doc._id);
                    }
                    if (doc._id.Length > 4 && doc._id.Substring(0, 4).Equals("http"))
                    {
                        url++;
                        Console.WriteLine("{0}. URL: {1}", url, doc._id);
                    }
                }

                float total = (float)(twitter + hashtag + url);

                Console.WriteLine();
                Console.WriteLine("Total de Ocorrências:");
                Console.WriteLine("a. Usuários Twitter: {0} ({1}%)", twitter, string.Format("{0:N}", ((float)twitter) / total * 100));
                Console.WriteLine("b. Hashtags: {0} ({1}%)", hashtag, string.Format("{0:N}", ((float)hashtag) / total * 100));
                Console.WriteLine("c. URLs: {0} ({1}%)", url, string.Format("{0:N}", ((float)url) / total * 100));
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                Console.ReadLine();
            }
        }
    }
}
