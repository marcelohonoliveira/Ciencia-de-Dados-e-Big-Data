## Exercício 01

Na coleção Vocabulary

**A)** Utilizando as funções de mapReduce do mongo, conte o número de palavras que terminam em ar, er, ir, or, ur.

No Mongo:
```javascript
load("E:/Google Drive/02 Pós CDBD/04 NSQ - Bancos de dados Não Relacionais/01 Aulas/03 Aula 03/Exercicio01a.js")
```

>Saída:
```javascript
{
        "result" : "conta_palavras",
        "timeMillis" : 1834,
        "counts" : {
                "input" : 7302,
                "emit" : 7302,
                "reduce" : 361,
                "output" : 5
        },
        "ok" : 1
}
{ "_id" : "ar", "value" : 2950 }
{ "_id" : "er", "value" : 2342 }
{ "_id" : "ir", "value" : 554 }
{ "_id" : "or", "value" : 1168 }
{ "_id" : "ur", "value" : 288 }
true
```

**B)** Utilizando as funções de mapReduce do mongo, conte o total de cada caracter existente no vocabulario. Por exemplo:

aula -> a:2, u:1, l:1

Para facilitar você pode escrever o código em um documento de texto e importa-lo usando a função load() do mongo shell

Ex.: > load(“/home/nosql/Aulas/nosql-class/aula3/ex1.js”)

```javascript
var map = function(){
	if (this.text == undefined) return; 

	for (var letra = 0; letra < this.text.length; letra++){ 
		  emit(this.text[letra], 1);
	}
}

var reduce = function(key, value){
	return Array.sum(value);
}

db.Vocabulary.mapReduce(map, reduce, {query:{}, out:"Resultado"})



 db.Resultado.find()
{ "_id" : "!", "value" : 344 }
{ "_id" : "#", "value" : 11110 }
{ "_id" : "$", "value" : 220 }
{ "_id" : "%", "value" : 127 }
{ "_id" : "&", "value" : 2 }
{ "_id" : "(", "value" : 6 }
}

var reduce = function(key, value){
	return Array.sum(value);
}

db.Vocabulary.mapReduce(map, reduce, {query:{}, out:"Resultado"})



 db.Resultado.find()
{ "_id" : "!", "value" : 344 }
{ "_id" : "#", "value" : 11110 }
{ "_id" : "$", "value" : 220 }
{ "_id" : "%", "value" : 127 }
{ "_id" : "&", "value" : 2 }
{ "_id" : "(", "value" : 6 }
{ "_id" : ")", "value" : 8 }
```
