## Exercício 01

Na coleção Vocabulary

No CMD:
```javascript
cd "C:\Program Files\MongoDB\Server\3.2\bin"
mongoimport --db Exercicio01 --collection Vocabulary --file "E:\Google Drive\02 Pós CDBD\04 NSQ - Bancos de dados Não Relacionais\01 Aulas\03 Aula 03\Vocabulary.json"
```

**A)** Utilizando as funções de mapReduce do mongo, conte o número de palavras que terminam em ar, er, ir, or, ur.

No Mongo:
```javascript
use Exercicio01
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

No Mongo:
```javascript
use Exercicio01
load("E:/Google Drive/02 Pós CDBD/04 NSQ - Bancos de dados Não Relacionais/01 Aulas/03 Aula 03/Exercicio01b.js")
```

>Saída:
```javascript
{
        "result" : "conta_caracteres",
        "timeMillis" : 39258,
        "counts" : {
                "input" : 291214,
                "emit" : 3905842,
                "reduce" : 125013,
                "output" : 61
        },
        "ok" : 1
}
{ "_id" : "!", "value" : 344 }
{ "_id" : "#", "value" : 11110 }
{ "_id" : "$", "value" : 220 }
{ "_id" : "%", "value" : 127 }
{ "_id" : "&", "value" : 2 }
{ "_id" : "(", "value" : 6 }
{ "_id" : ")", "value" : 8 }
{ "_id" : "*", "value" : 7 }
{ "_id" : ",", "value" : 58 }
{ "_id" : "-", "value" : 17 }
{ "_id" : ".", "value" : 83708 }
{ "_id" : "/", "value" : 241469 }
{ "_id" : "0", "value" : 21943 }
{ "_id" : "1", "value" : 24276 }
{ "_id" : "2", "value" : 20777 }
{ "_id" : "3", "value" : 17791 }
{ "_id" : "4", "value" : 16930 }
{ "_id" : "5", "value" : 16626 }
{ "_id" : "6", "value" : 16037 }
{ "_id" : "7", "value" : 16950 }
{ "_id" : "8", "value" : 16111 }
{ "_id" : "9", "value" : 17718 }
{ "_id" : ":", "value" : 130977 }
{ "_id" : ";", "value" : 701 }
{ "_id" : "<", "value" : 57 }
{ "_id" : "=", "value" : 155 }
{ "_id" : ">", "value" : 76 }
{ "_id" : "?", "value" : 13074 }
{ "_id" : "@", "value" : 90009 }
{ "_id" : "[", "value" : 1009 }
{ "_id" : "\\", "value" : 70 }
{ "_id" : "]", "value" : 1225 }
{ "_id" : "^", "value" : 21 }
{ "_id" : "_", "value" : 25413 }
{ "_id" : "`", "value" : 45 }
{ "_id" : "a", "value" : 288288 }
{ "_id" : "b", "value" : 64116 }
{ "_id" : "c", "value" : 174545 }
{ "_id" : "d", "value" : 91114 }
{ "_id" : "e", "value" : 186273 }
{ "_id" : "f", "value" : 53056 }
{ "_id" : "g", "value" : 60855 }
{ "_id" : "h", "value" : 150811 }
{ "_id" : "i", "value" : 172221 }
{ "_id" : "j", "value" : 41956 }
{ "_id" : "k", "value" : 50996 }
{ "_id" : "l", "value" : 114093 }
{ "_id" : "m", "value" : 90167 }
{ "_id" : "n", "value" : 129568 }
{ "_id" : "o", "value" : 252402 }
{ "_id" : "p", "value" : 145352 }
{ "_id" : "q", "value" : 32703 }
{ "_id" : "r", "value" : 157747 }
{ "_id" : "s", "value" : 221626 }
{ "_id" : "t", "value" : 345977 }
{ "_id" : "u", "value" : 90389 }
{ "_id" : "v", "value" : 54429 }
{ "_id" : "w", "value" : 34121 }
{ "_id" : "x", "value" : 34814 }
{ "_id" : "y", "value" : 42249 }
{ "_id" : "z", "value" : 40907 }
true
```
