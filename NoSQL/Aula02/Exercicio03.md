## Exercício 03

###Sistema de cadastro de alunos:

* O sistema deve permitir inserir um novo aluno com nome, data de nascimento
* Adicionar a um aluno disciplinas que está cursando e cursadas
* Adicionar notas de um aluno a uma determinada disciplina
* Adicione esse arquivo em seu github em uma pasta chamada aula2

>Solução disponível [aqui](Exercicio03 "Aplicação C#") (Solução Visual Studio - Projeto em C#).
>_Dados armazenados pela aplicação:_
```javascript
> use Exercicio03
> db.Alunos.find().pretty()
{
        "_id" : ObjectId("584af6b86ba7801c7496293a"),
        "nome_aluno" : "Aluno01",
        "data_nascimento" : ISODate("1981-07-23T03:00:00Z"),
        "disciplinas" : [
                {
                        "Nome" : "NSQ",
                        "Cursada" : true,
                        "Nota" : 85.5
                },
                {
                        "Nome" : "AQD",
                        "Cursada" : false,
                        "Nota" : 75
                }
        ]
}
```

[<img src="Exercicio03/Screenshot_Exercicio03.png" align="center" width="100%" height="100%"/>](Exercicio03)
