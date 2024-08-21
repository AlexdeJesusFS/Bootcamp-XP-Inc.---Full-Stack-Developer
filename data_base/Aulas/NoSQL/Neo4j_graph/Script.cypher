//Data base Neo4j, db NoSQL baseado em grafos (graph), utiliza a linguaguem cypher
//CRIAR (:Legenda do nó {aqui vai os atributos, podendo ser valor único ou lista}) 
CREATE (:Client {name: "Bob Esponja", age: 28, hobbies: ["Caça agua-viva", "Comer hambuguers"]});

//criando mais um nó e seu relacionamento com outro novo nó criado 
//- [:Legenda do relacionamento]->(outro nó)
CREATE 
(:Client {name: "Lula Molusco", age: 30, hobbies: ["tocar clarinete", "adimirar arte"]})
-[:Bloqueado]->
(:Client {name: "Patrick Estrela", hobbies: ["comer", "dormir", "Caça agua-viva"]});

/*MATCH (n) → procura por todos os nós no grafo. O (n) é uma variável que representa qualquer nó
RETURN n → retornar/exibi todos os nós encontrados*/
MATCH (n) RETURN n;

/*com MATCH crio a varialve 'lula' e atribuo nela o valor nó que possui label Client e properties name igual a 'Lula Molusco'
crio a variavel relaciona e coloca nela o relacionamento Bloqueado de Lula com DELETE todos seus relacionamento Bloqueado são deletados */
MATCH (lula:Client {name: "Lula Molusco"})-[relaciona:Bloqueado]-() DELETE relaciona;

/*da mesma forma como feito antes com MATCH é criado e atribuido o nó de Lula e com DELETE esse nó é deletado*/
MATCH (lula:Client {name: "Lula Molusco"}) DELETE lula;

/*com a variavel patrick e o comando SET para alterar é criado a propriedade age com valor 25 nesse nó*/
MATCH (patrick:Client {name: "Patrick Estrela"}) SET patrick.age = 25;

//adicionando uma nova label
MATCH (patrick:Client {name: "Patrick Estrela"}) SET patrick:Client_Premium;

/*criando relacionamento entre nós existente*/
MATCH (bob:Client {name:"Bob Esponja"}), (patrick:Client {name: "Patrick Estrela"})
CREATE (bob)-[:Amigo]->(patrick)
CREATE (patrick)-[:Amigo]->(bob);//para relacionamento bidirecional

MATCH (patrick {name: "Patrick Estrela"})
REMOVE patrick:Cliente //remove a label do nó patrick
REMOVE patrick.age; //remove a properties do nó patrick
