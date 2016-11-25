## Exercício 01

Criando um Banco:

```javascript
use Exercicio01
```

Escolha 3 colegas e:
* Insira no banco informações sobre você e seus colegas como nome, data de nascimento
disciplinas cursadas e em curso na PUC
```javascript
db.Alunos.insertMany([{
                         "nome"			: "Aluno 01"
                        ,"dataNascimento"	: ISODate("1980-01-01T00:00:00Z")
			,"IBD_concluida"	: True
			,"IBD_nota"		: 80
			,"ILE_concluida"	: True
			,"ILE_nota"		: 70
			,"AQD_concluida"	: False
			,"AQD_nota"		: 0
			,"NSQ_concluida"	: False
			,"NSQ_nota"		: 0
		 }
		,{
                         "nome"			: "Aluno 02"
                        ,"dataNascimento"	: ISODate("1979-06-01T00:00:00Z")
			,"IBD_concluida"	: True
			,"IBD_nota"		: 60
			,"ILE_concluida"	: True
			,"ILE_nota"		: 50
			,"AQD_concluida"	: False
			,"AQD_nota"		: 0
			,"NSQ_concluida"	: False
			,"NSQ_nota"		: 0
		 }
		,{
                         "nome"			: "Aluno 03"
                        ,"dataNascimento"	: ISODate("1978-12-01T00:00:00Z")
			,"IBD_concluida"	: True
			,"IBD_nota"		: 40
			,"ILE_concluida"	: True
			,"ILE_nota"		: 30
			,"AQD_concluida"	: False
			,"AQD_nota"		: 0
			,"NSQ_concluida"	: False
			,"NSQ_nota"		: 0
		 }])
```

* Procure no banco a pessoa com a menor data de nascimento
```javascript
db.Alunos.find().sort({dataNascimento: 1}).limit(1)
```

* Atualize a sua nota na disciplina NoSQL para 5
```javascript
db.Alunos.update( {"nome": "Aluno 01",
                  "disciplinasEmCurso.nome": "NSQ"},
                  {$set: {"disciplinasEmCurso.nota" : 5}})
```

* Apague um de seus colegas
```javascript
try {
   db.Alunos.deleteOne( {"nome": "Aluno 03" } );
} catch (e) {
   print(e);
}
```

* Copie e cole essas operações em um arquivo e adicione em seu github em uma pasta chamada Aula02
