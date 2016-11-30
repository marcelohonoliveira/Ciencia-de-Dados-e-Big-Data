## Exercício 01

Na coleção Vocabulary

**A)** Utilizando as funções de mapReduce do mongo, conte o número de palavras que terminam em ar, er, ir, or, ur.


```javascript
var map = function(){
	emit(this.text.substring(this.text.length-2,this.text.length),1);
}

var reduce = function(key, values){
	return Array.sum(values);
}

db.Vocabulary.mapReduce(map,reduce,{query:
{
		text:  /((ar)|(er)|(ir))$/
}
 , out:"resultado"})


db.resultado.find()


{
	"result" : "resultado",
	"timeMillis" : 282,
	"counts" : {
		"input" : 5846,
		"emit" : 5846,
		"reduce" : 177,
		"output" : 3
	},
	"ok" : 1
}

db.resultado.find()
{ "_id" : "ar", "value" : 2950 }
{ "_id" : "er", "value" : 2342 }
{ "_id" : "ir", "value" : 554 }
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
