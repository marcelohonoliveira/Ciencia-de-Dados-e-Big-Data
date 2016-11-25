## Exercício 01

Criando um Banco:

```javascript
use Exercicio01
```

Escolha 3 colegas e:
* Insira no banco informações sobre você e seus colegas como nome, data de nascimento
disciplinas cursadas e em curso na PUC
```javascript
db.Alunos.insertMany([
{
        "nome_aluno" : "Aluno 01",
        "data_nascimento" : ISODate("1980-01-01T00:00:00Z"),
        "IBD_cursada" : 1,
        "IBD_nota" : 80,
        "ILE_cursada" : 1,
        "ILE_nota" : 70,
        "AQD_cursada" : 0,
        "AQD_nota" : 0,
        "NSQ_cursada" : 0,
        "NSQ_nota" : 0
},
{
        "nome_aluno" : "Aluno 02",
        "data_nascimento" : ISODate("1979-06-01T00:00:00Z"),
        "IBD_cursada" : 1,
        "IBD_nota" : 60,
        "ILE_cursada" : 1,
        "ILE_nota" : 50,
        "AQD_cursada" : 0,
        "AQD_nota" : 0,
        "NSQ_cursada" : 0,
        "NSQ_nota" : 0
},
{
        "nome_aluno" : "Aluno 03",
        "data_nascimento" : ISODate("1978-12-01T00:00:00Z"),
        "IBD_cursada" : 1,
        "IBD_nota" : 40,
        "ILE_cursada" : 1,
        "ILE_nota" : 30,
        "AQD_cursada" : 0,
        "AQD_nota" : 0,
        "NSQ_cursada" : 0,
        "NSQ_nota" : 0
}])
```
>Saída:

```javascript
{
        "acknowledged" : true,
        "insertedIds" : [
                ObjectId("58386f7e9a48a513ac16e794"),
                ObjectId("58386f7e9a48a513ac16e795"),
                ObjectId("58386f7e9a48a513ac16e796")
        ]
}
```

* Procure no banco a pessoa com a menor data de nascimento
```javascript
db.Alunos.find().sort({data_nascimento: 1}).limit(1)
```
>Saída:

```javascript
{ "_id" : ObjectId("58386f7e9a48a513ac16e796"), "nome_aluno" : "Aluno 03", "data_nascimento" : ISODate("1978-12-01T00:00:00Z"), "IBD_cursada" : 1, "IBD_nota" : 40, "ILE_cursada" : 1, "ILE_nota" : 30, "AQD_cursada" : 0, "AQD_nota" : 0, "NSQ_cursada" : 0, "NSQ_nota" : 0 }
```

* Atualize a sua nota na disciplina NoSQL para 5
```javascript
db.Alunos.update( {"nome_aluno": "Aluno 01"}, {$set: {"NSQ_nota" : 5}})
```

>Saída:

```javascript
WriteResult({ "nMatched" : 1, "nUpserted" : 0, "nModified" : 1 })
```

* Apague um de seus colegas
```javascript
try {
   db.Alunos.deleteOne( {"nome_aluno": "Aluno 02" } );
} catch (e) {
   print(e);
}
```

>Saída:

```javascript
{ "acknowledged" : true, "deletedCount" : 1 }
```

* Copie e cole essas operações em um arquivo e adicione em seu github em uma pasta chamada Aula02
