var result_cursor = db.Vocabulary.aggregate([
        { $match: { total: { $gt: 1000 } } },
        {
            $group: {
                _id: { type: "$type" },
                qty: { $sum: 1 }
            }
        },
        { $sort: { "_id.type": 1 } }
    ]);

//printjson(result_cursor);

while (result_cursor.hasNext()) {
    printjson(result_cursor.next());
}

result_cursor.close();