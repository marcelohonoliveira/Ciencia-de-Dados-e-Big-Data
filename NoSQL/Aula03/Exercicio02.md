##Exercício 02
Utilizando a função de agregação contar quantos itens cujo o campo total seja maior do que 1000, agrupando-os por tipo, (campo type) e exiba o resultado em ordem crescente.
```javascript
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

result_cursor.pretty();

while (result_cursor.hasNext()) {
    printjson(result_cursor.next());
}

result_cursor.close();
```
