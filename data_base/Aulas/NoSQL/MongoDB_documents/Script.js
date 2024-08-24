/*Data base MongoDB: NoSQL orientado a documentos, o documento usado é no formato BSON
*BSON: Binary JSON, é semelhante ao JSON, porém com tipos de dados mais, como data e hora e binários  
Mongo permite criar scripts de comandos em arquivo.js para execução no mongosh (mongo shell), executando assim comando do banco e javascript   
Documentação: https://www.mongodb.com/pt-br/docs/mongodb-shell/crud/   */


//use data_base → script executado já conectado no data base
//realiza a conexão com o data base que no caso está em nuvem
db = connect("mongodb+srv://alexjesus:Lex1916@cluster0.hmtkl.mongodb.net/");

/*criar coleção explicitamente
capped: capped (limitado), defini que a coleção terá um limite.
size: tamanho máximo da coleção em bytes.
max: número máximo de documentos permitidos.
Quando esse limite é atingido, os documentos antigos são automaticamente removidos para dar lugar aos novos.  */
db.createCollection("logs", { capped: true, size: 5242880, max: 5000 })

//mostrar todas as coleções do banco em que está selecionado
//show collections

//listar todos os documentos da coleção clients quando sem filtro
db.clients.find()

//find com filtro
db.clients.find({name: "Lula Molusco", age: 35})


//função depreciada! inserir arquivo na coleção, nesse caso uma lista:
db.clients.insert([{"name": "Patrick", "age": 25}, {"name": "Bob Esponja"}])

//métodos de inserção atuais: insertOne, insertMany, or bulkWrite.
//comando para criar um documento na coleção, caso essa coleção não exista com esse comando ela será criada implicitamente
//insertOne(inserir UM) → inseri somente um arquivo na coleção
db.test.insertOne({"name": "Test 2"});

//insertMany(inserir Muitos) → inseri uma lista de arquivos
db.clients.insertMany([{"name": "Patrick", "age": 25}, {"name": "Bob Esponja"}])

//bulkWrite(escrita em massa) → realiza diversar operações diferentes de uma vez
/*Operações disponíveis:
insertOne: Insere um único documento.
updateOne: Atualiza um único documento que corresponde ao filtro.
updateMany: Atualiza todos os documentos que correspondem ao filtro.
deleteOne: Remove um único documento que corresponde ao filtro.
deleteMany: Remove todos os documentos que correspondem ao filtro.
replaceOne: Substitui um documento que corresponde ao filtro por um novo documento.   */
db.clients.bulkWrite([
    { insertOne: { "document": { name: "Lula Molusco", age: 32} } },
    { updateOne: { "filter": { name: "Patrick" }, "update": { $set: { name: "Patrick Estrela" } } } },
    { deleteOne: { "filter": { name: "Lula Molusco" } } }
    ])
//*chave do arquivo pode ser criada com ou sem aspas""

/* no momento estive usando a verão 7.0.12, já nessa versão a função save foi removida para dar espaço a outras funções
a função save criava um arquivo caso informado sem '_id' ou atualiza caso informado com '_id'
db.clients.save({_id: ObjectId("66c93695e6c737c7a852447e"), name: "Patrick Estrela"})
TypeError: db.clients.save is not a function
*/
//atualizar arquivos

/*updateOne (atualizar UM) atualiza a primeira correspondencia, somente um arquivo 
→ primeiro parâmetro é o filtro pelo qual será feita a busca do arquivo, podendo ser qualquer valor que o arquivo tenha, para correspodencia exata use o _id
→ segundo parametro é o valor que será atualizado   */
db.clients.updateOne({_id: ObjectId("66c93695e6c737c7a852447e")}, {$set: {name: "Patrick Estrela"}})

//updateMany (atualiza muitos) atuliza todos as correspondecia para o filtro, todos os arquivos com metch
db.clients.updateMany({_id: ObjectId("66c93695e6c737c7a852447e")}, {$set: {name: "Patrick Estrela"}})

//replaceOne (substituir UM) substitui o arquivo encontrado pelo novo
//primeiro parâmetro filtro; segundo parâmetro novo arquivo
db.clients.replaceOne({_id: ObjectId("66c93695e6c737c7a852447e")}, {name: "Patrick Estrela"})


db.clients.bulkWrite([{ updateOne: { "filter": { name: "Patrick Estrela" }, "update": { $set: {age: 30} } } }, {updateOne: {"filter": {name: "Bob Esponja"}, "update": { $set: {age: 25}}}}])


//busca com operadores:
db.clients.find({ $or: [ {name: "Patrick Estrela"}, {age: 25} ]})

db.clients.find({ $and: [ {name: "Patrick Estrela"}, {age: 30} ]})

db.clients.find({ age: {$in: [25, 30, 35]}})

db.clients.find({ age: { $lt: 30 } }) //menor que

db.clients.find({ age: { $gt: 30 } }) //maior que

db.clients.find({ age: { $ne: 30 } }) //diferente

db.clients.find({ age: { $eq: 30 } }) //igual

//deleção:
//deletar UM: deleta um único arquivo em que houver match com a busca
db.clients.deleteOne({age: 35})

//deletar muitos: deleta todo arquivo der match com a busca, deleta mais de um arquivo
db.clients.deleteMany({age: 35})


print("script executado!");
