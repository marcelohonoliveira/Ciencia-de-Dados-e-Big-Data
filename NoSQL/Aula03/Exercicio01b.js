var map_fn = function() {
    if (this.text == undefined) return;

    for (var i = 0; i < this.text.length; i++) {
        emit(this.text[i], 1);
    }
};

var reduce_fn = function(key, value) {
    return Array.sum(value);
};

var result = db.Vocabulary.mapReduce(
        map_fn,
        reduce_fn,
        {
            query: {},
            out: "conta_caracteres"
        }
    );

printjson(result);

var cursor = db.conta_caracteres.find({});
while (cursor.hasNext()) {
    printjson(cursor.next())
}

cursor.close();