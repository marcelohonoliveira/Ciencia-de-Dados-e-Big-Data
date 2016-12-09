using System;
using MongoDB.Bson;
using MongoDB.Driver;
using Tweetinvi;

namespace TwitterListenerPlus
{
    /*
        *** PREPARAÇÃO DO AMBIENTE E DOS DADOS ***

            1) Instalar pacote Tweetinvi à Solução:
                Referência:
                    https://www.nuget.org/packages/TweetinviAPI
                Comando PMC:
                    PM> Install-Package TweetinviAPI -Version 1.1.1
            2) Instalar pacote MongoDB à Solução:
                Referência:
                    https://www.nuget.org/packages/MongoDB.Driver/2.3.0
                Comando PMC:
                    PM> Install-Package MongoDB.Driver -Version 2.3.0

            3) Iniciar o serviço do MongoDB:
                CMD Windows:
                    cd "C:\Program Files\MongoDB\Server\3.2\bin"
                    mongod --dbpath="C:/Program Files/MongoDB/Data"
    */

    class Program
    {
        static void Main()
        {

            try
            {
                string consumerKey = "[consumerKey]";
                string consumerSecret = "[consumerSecret]";
                string userAccessToken = "[userAccessToken]";
                string userAccessSecret = "[userAccessSecret]";

                Auth.SetUserCredentials(consumerKey, consumerSecret, userAccessToken, userAccessSecret);

                string conexaoMongo = "mongodb://localhost/";
                var client = new MongoClient(conexaoMongo);
                var db = client.GetDatabase("TwitterListenerPlus");
                var col = db.GetCollection<Tweet>("Tweets");

                var stream = Stream.CreateFilteredStream();
                stream.AddTrack("forçachape");
                stream.AddTrack("forcachape");
                stream.AddTrack("chapecoense");

                Int64 count = 0;

                stream.MatchingTweetReceived += (sender, args) =>
                {
                    count++;
                    Console.WriteLine("Tweet nº {0}:\n{1}\n\n", count.ToString("0000000"), args.Tweet);
                    col.InsertOne(new Tweet(args.Tweet.CreatedAt, args.Tweet.IdStr, args.Tweet.Text, args.Tweet.Language.ToString()));
                };

                stream.StartStreamMatchingAllConditions();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                Console.ReadLine();
            }
        }
    }
}
