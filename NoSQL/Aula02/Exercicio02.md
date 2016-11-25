## Exercício 02

###Contando palavras


Criando um Banco:

```javascript
use Exercicio02
```

Primeiramente importe os dados do arquivo ~Aulas/nosql-class/aula2/Vocabulary.json para o banco de dados nosqlclass e a coleção Vocabulary
./bin/mongoimport -d nosqlclass -c Vocabulary nosql-class/aula2/Vocabulary.json

```javascript
cd C:\Program Files\MongoDB\Server\3.2\bin
mongoimport --db Exercicio02 --collection Vocabulary --file "E:\Google Drive\02 Pós CDBD\04 NSQ - Banco de dados Não Relacionais\01 Aulas\02 Aula 02\Vocabulary.json"
```

>_Saída:_

```javascript
2016-11-25T19:29:12.549-0200    connected to: localhost
2016-11-25T19:29:14.005-0200    [........................] Exercicio02.Vocabulary       205KB/22.1MB (0.9%)
2016-11-25T19:29:16.957-0200    [#####...................] Exercicio02.Vocabulary       5.36MB/22.1MB (24.2%)
2016-11-25T19:29:19.956-0200    [###########.............] Exercicio02.Vocabulary       10.5MB/22.1MB (47.5%)
2016-11-25T19:29:22.959-0200    [#################.......] Exercicio02.Vocabulary       15.9MB/22.1MB (71.9%)
2016-11-25T19:29:25.958-0200    [######################..] Exercicio02.Vocabulary       21.2MB/22.1MB (95.7%)
2016-11-25T19:29:26.519-0200    [########################] Exercicio02.Vocabulary       22.1MB/22.1MB (100.0%)
2016-11-25T19:29:26.520-0200    imported 291214 documents
```

Complete o código do arquivo que está dentro de ~Aulas/nosql-class/aula2/ex2.py
* Liste as dez palavras com o maior valor no campos total e as imprima na tela.
* Encontre todas as palavras que são usuários do twitter, hashtags, urls e adicione um campo
informando o tipo da palavra.
* Conte o total de cada um dos tipos que você criou.


```python
CODE
```

>_Saída:_

```
RESULT
```
