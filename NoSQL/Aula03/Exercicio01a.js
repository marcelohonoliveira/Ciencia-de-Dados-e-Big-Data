var map_fn = function()
{
    emit(this.text.substring(this.text.length - 2, this.text.length), 1);
}

var reduce_fn = function(key, values)
{
    return Array.sum(values);
}

var result = db.Vocabulary.mapReduce(
	map_fn,
	reduce_fn,
	{
		query: {text:  /((ar)|(er)|(ir)|(or)|(ur))$/},

		out: "conta_palavras"
	}

);



printjson(result);



var cursor = db.conta_palavras.find({});
while (cursor.hasNext())
{
	printjson(cursor.next())

}


cursor
cursor.close();