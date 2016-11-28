## Exercício 01

Faça uma pesquisa simples na coleção Vocabulary pelo termo “feliz” no campo text e diga:

a) Número de documentos que foi escaneado

```javascript
db.Vocabulary.find({"text":"feliz"}).explain({"text":1})

"totalDocsExamined" : 291214,
```

b) Tempo que levou para fazer a consulta

```javascript
"executionTimeMillis" : 101,
```

c) Crie um índice simples no campo text

```javascript
db.Vocabulary.createIndex({"text":1})
{
	"createdCollectionAutomatically" : false,
	"numIndexesBefore" : 1,
	"numIndexesAfter" : 2,
	"ok" : 1
}
```
d) Número de documentos que foi escaneado

```javascript
"totalDocsExamined" : 1,
```

e) Tempo que levou para fazer a consulta

```javascript
"executionTimeMillis" : 18,
```
