var map_fn = function ()
{
	if (this.text == undefined)
		return;

	var regExp = new RegExp("[^a-záàâãäéèêëíìîïóòôõöúùûüçñ ]", "gi");

	var words = this.text.replace(regExp, "").replace(/\n/gi, " ").replace(/\t/gi, " ").replace(/\r/gi, " ").replace(/\s{2,}/g, " ").replace(/[áàâãä]/gi, "a").replace(/[éèêë]/gi, "e").replace(/[íìîï]/gi, "i").replace(/[óòôõö]/gi, "o").replace(/[úùûü]/gi, "u").replace(/ç/gi, "c").toUpperCase().split(" ");

	for (var i = 0; i < words.length; i++)
	{
		if (words[i] != "")
			emit(words[i], 1);
	}
};

var reduce_fn = function (key, value)
{
    return Array.sum(value);
};

var result = db.Tweets.mapReduce(
                        map_fn,
                        reduce_fn,
                        {
                            query: {},
                            out: "Terms"
                        });

print();
print("---------------------------------------------------------------------");
print("                      Resultado do MapReduce");
print("---------------------------------------------------------------------");

printjson(result);

print();
print();
print("---------------------------------------------------------------------");
print("     Lista dos 20 Termos mais frequentes - SEM TRATAMENTO");
print("---------------------------------------------------------------------");

var cursor_freq_terms = db.Terms.find().limit(20).sort({ value: -1 });

while (cursor_freq_terms.hasNext())
{
    printjson(cursor_freq_terms.next())
}

cursor_freq_terms.close();


print();
print();
print("---------------------------------------------------------------------");
print("                     Volume de Tweets por Dia");
print("---------------------------------------------------------------------");

var cursor_tweets_day = db.Tweets.aggregate({ $group: { _id: { $dateToString: { format: "%Y-%m-%d", date: "$created_at" } }, total: { $sum: 1 } } }
					   , { $sort: { _id: 1 } });

while (cursor_tweets_day.hasNext())
{
    printjson(cursor_tweets_day.next())
}

cursor_tweets_day.close();


print();
print();
print("---------------------------------------------------------------------");
print("                     Volume de Tweets por Hora");
print("---------------------------------------------------------------------");

var cursor_tweets_hour = db.Tweets.aggregate({ $group: { _id: { $dateToString: { format: "%Y-%m-%d %H:00", date: "$created_at" } }, total: { $sum: 1 } } }
					    , { $sort: { _id: 1 } });

while (cursor_tweets_hour.hasNext())
{
    printjson(cursor_tweets_hour.next())
}

cursor_tweets_hour.close();