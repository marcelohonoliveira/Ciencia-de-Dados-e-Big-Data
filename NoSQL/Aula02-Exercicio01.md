## Exercício 01

Criando um Banco:

```javascript
use Exercicio01
```

Escolha 3 colegas e:
* Insira no banco informações sobre você e seus colegas como nome, data de nascimento
disciplinas cursadas e em curso na PUC
```javascript
db.Alunos.insertMany( [{
                        "nome": "Aluno 01",
                        "dataNascimento": ISODate("1980-01-01T00:00:00Z"),
                        "disciplinasCursadas":	[
                                {	nome: "IBD",
                                  nota: 80
                                },
                                {	nome: "ILE",
                                  nota: 70
                                }
                              ],
                        "disciplinasEmCurso":	[
                                {	nome: "AQD",
                                  nota: 0
                                },
                                {	nome: "NSQ",
                                  nota: 0
                                }
                              ]
                      },
                      {
                        "nome": "Aluno 02",
                        "dataNascimento": ISODate("1981-01-01T00:00:00Z"),
                        "disciplinasCursadas":	[
                                {	nome: "IBD",
                                  nota: 85
                                },
                                {	nome: "ILE",
                                  nota: 75
                                }
                              ],
                        "disciplinasEmCurso":	[
                                {	nome: "AQD",
                                  nota: 0
                                },
                                {	nome: "NSQ",
                                  nota: 0
                                }
                              ]
                      },
                      {
                        "nome": "Aluno 03",
                        "dataNascimento": ISODate("1982-01-01T00:00:00Z"),
                        "disciplinasCursadas":	[
                                {	nome: "IBD",
                                  nota: 90
                                },
                                {	nome: "ILE",
                                  nota: 10
                                }
                              ],
                        "disciplinasEmCurso":	[
                                {	nome: "AQD",
                                  nota: 0
                                },
                                {	nome: "NSQ",
                                  nota: 0
                                }
                              ]
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

* Copie e cole essas operações em um arquivo e adicione em seu github em uma pasta chamada aula2
