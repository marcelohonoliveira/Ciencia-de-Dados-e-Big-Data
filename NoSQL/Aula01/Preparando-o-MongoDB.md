## Preparando o Banco de Dados Mongo DB

### PARA WINDOWS:

#### Iniciar o serviço para o Mongo DB
No Primeiro Terminal (cmd como Administrador):
```
mkdir "C:\Program Files\MongoDB\Data\"
cd "C:\Program Files\MongoDB\Server\3.2\bin"
mongod --dbpath="C:/Program Files/MongoDB/Data" --storageEngine=mmapv1
```

#### Executar o MongoDB
No Segundo Terminal (cmd):
```
cd "C:\Program Files\MongoDB\Server\3.2\bin"
mongo
```
---
### PARA LINUX:
#### Iniciar o serviço para o Mongo DB
No Primeiro Terminal:
```
cd ~/Aulas/mongodb; ./bin/mongod --dbpath=../dados
```

#### Executar o MongoDB
No Segundo Terminal:
```
cd ~/Aulas/mongodb; ./bin/mongo
```
