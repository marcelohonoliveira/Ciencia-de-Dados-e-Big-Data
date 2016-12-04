##Exercício 02

```javascript
cd "C:\Program Files\MongoDB\Server\3.2\bin"
mongoimport --db Exercicio02 --collection Vocabulary --file "E:\Google Drive\02 Pós CDBD\04 NSQ - Bancos de dados Não Relacionais\01 Aulas\03 Aula 03\Vocabulary.json"
```

Utilizando a função de agregação contar quantos itens cujo o campo total seja maior do que 1000, agrupando-os por tipo, (campo type) e exiba o resultado em ordem crescente.

No Mongo:
```javascript
use Exercicio02
load("E:/Google Drive/02 Pós CDBD/04 NSQ - Bancos de dados Não Relacionais/01 Aulas/03 Aula 03/Exercicio02.js")
```

>Saída:
```javascript
{ "_id" : { "type" : 1 }, "qty" : 1 }
{ "_id" : { "type" : 3 }, "qty" : 2 }
{ "_id" : { "type" : 4 }, "qty" : 12 }
{ "_id" : { "type" : 5 }, "qty" : 744 }
{ "_id" : { "type" : 6 }, "qty" : 2 }
{ "_id" : { "type" : 8 }, "qty" : 6 }
{ "_id" : { "type" : 9 }, "qty" : 5 }
true
```
