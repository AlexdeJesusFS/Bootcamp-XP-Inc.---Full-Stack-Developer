/*Cassandra data base, baseado em colunas. usado por terminal cql
utiliza de tabelas, porém é distribuído e orientado a colunas*/

/*O keyspace é o equivalente a um database, agrupa todas as tabelas, um conjunto de tabelas
replication class: é a forma de como e onde os dados são replicados
SimpleStrategy para um único datacenter ou 
NetworkTopologyStrategy para múltiplos datacenters.

replication factor: quantas cópias os dados vão ter no cluster, isso que ajuda na alta disponibilidade e redundância dos dados. A boa prática é 3.   */
CREATE KEYSPACE fenda_biquini WITH replication = {'class': 'SimpleStrategy', 'replication_factor': 1};

--indica que estamos usando o keyspace fenda_biquini
USE fenda_biquini;

/* em versão mais recente atualizado para: CREATE TABLE
criar tabela nome (colunas tipo_dado, ...) WITH opções;  */
CREATE COLUMNFAMILY clients (
    name TEXT PRIMARY KEY, 
    age INT);

--inserção de dados: inserir na tabela clients nas colunas name, age valores bob, 20
INSERT INTO clients (name, age) VALUES ('Bob Esponja', 20);

--forma de inserção usando formato JSON:
INSERT INTO clients JSON '{"name": "Patrick"}';

--seleção de valores especificos: selecione tudo de clients onde name == 'Bob Esponja'
SELECT * FROM clients WHERE name = 'Bob Esponja';

--retorna exibindo no formato JSON:
SELECT JSON * FROM clients;

--atualizando na tabela clients alterando age para 25 onde name == 'Patrick'
UPDATE clients SET age = 25 WHERE name = 'Patrick';

/*cassandra possui tipo de dado como coleções
list - conjunto ordenado em ordem de inserção, valores repetidos são permitidos
set - desordenado e valores não são permitidos
map - conjunto com chave e valor, semelhante a um dictionary */
--alterar a tebela clients add coluna hobby tipo de dado:
ALTER TABLE clients ADD hobby set<text>;

UPDATE clients SET hobby = hobby + {'caça agua-viva','comer', 'dormir'} WHERE name = 'Patrick';
