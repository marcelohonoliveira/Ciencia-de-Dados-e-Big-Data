## Exercício 01

Criando um Banco:

```javascript
use Exercicio01
```

Escolha 3 colegas e:
* Insira no banco informações sobre você e seus colegas como nome, data de nascimento
disciplinas cursadas e em curso na PUC
* Procure no banco a pessoa com a menor data de nascimento

```javascript
db.Alunos.InsertMany( [{
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
